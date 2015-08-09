using System.Management;

namespace SystemInfo
{
    using System;
    using System.Windows.Forms;
    using Microsoft.Win32;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Media;
    using Properties;
    using static System.Windows.Forms.SystemInformation;

    public partial class SysInfoForm : Form
    {
        public SysInfoForm()
        {
            InitializeComponent();
        }
        //
        // FORM LOAD
        //
        private void SysInfoForm_Load(object sender, EventArgs e)
        {
            ChangeLanguage(Settings.Default.activeLang == @"en_us" ? "en_us" : "bg");

            if (Settings.Default.startUpSound == "on")
            {
                try
                {
                    var player = new SoundPlayer() { SoundLocation = @"Sounds/startup.wav" };
                    player.Play();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + @"Sounds/startup.wav");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //
        // STARTUP SOUND ON
        //
        private void startUpSoundOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.startUpSound = "on";
            Settings.Default.Save();
        }
        //
        // STARTUP SOUND OFF
        //
        private void startUpSoundOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.startUpSound = "off";
            Settings.Default.Save();
        }
        //
        // US LANG
        //
        private void englishUnitedStatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en_us");
            Settings.Default.activeLang = "en_us";
            Settings.Default.Save();
        }
        //
        // LANG_BG
        //
        private void bulgarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("bg");
            Settings.Default.activeLang = "bg";
            Settings.Default.Save();
        }
        //
        // CHANGE LANG
        //
        private void ChangeLanguage(string langCode)
        {
            var languageType = string.Empty;

            switch (langCode)
            {
                case "bg": languageType = "SystemInfo.Langs.LANG_BG"; break;
                case "en_us": languageType = "SystemInfo.Langs.LANG_EN_US"; break;
            }

            var assembly = Assembly.Load(@"SystemInfo");
            var resourceManager = new ResourceManager(languageType, assembly);

            getInfoButton.Text = resourceManager.GetString(@"getInfoButton");
            resetInfoButton.Text = resourceManager.GetString(@"resetInfoButton");
            saveInfoButton.Text = resourceManager.GetString(@"saveInfoButton");
            settingsToolStripMenuItem.Text = resourceManager.GetString(@"settingsMenu");
            languagesToolStripMenuItem.Text = resourceManager.GetString(@"languagesMenu");
            bulgarianToolStripMenuItem.Text = resourceManager.GetString(@"bulgarianLangMenu");
            englishUnitedStatesToolStripMenuItem.Text = resourceManager.GetString(@"englishLangMenu");
            aboutToolStripMenuItem.Text = resourceManager.GetString(@"aboutMenu");
            creditsToolStripMenuItem.Text = resourceManager.GetString(@"creditsMenu");
            viewOnlineToolStripMenuItem.Text = resourceManager.GetString(@"viewOnlineMenu");
        }
        //
        // SYSTEM INFO LIST VIEW
        //
        private void sysInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        // GET INFO BUTTON
        //
        private void getInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sysInfoListView.Items.Count > 0)
                {
                    throw new ArgumentException("Reset firstly please.");
                }

                // GET SYSTEM INFO
                var sysDirectory = string.Format("System directory: {0}", Environment.SystemDirectory);
                var sysRunTime = string.Format("System runtime: {0} minutes ago", ((Environment.TickCount / 1000) / 60));
                var sysOsVersion = string.Format("OS version: {0}", Environment.OSVersion);
                var sysOsName = string.Format("OS name: {0}",
                    new Microsoft.VisualBasic.Devices.ComputerInfo().OSFullName);

                var osQuery = new WqlObjectQuery("SELECT * FROM Win32_OperatingSystem");
                var objSearcher = new ManagementObjectSearcher(osQuery);
                var sysOsProductId = string.Empty;
                foreach (var obj in objSearcher.Get())
                {
                    sysOsProductId = ("OS Product ID: " + obj["SerialNumber"]);
                }

                var biosQuery = new WqlObjectQuery("SELECT * FROM Win32_Bios");
                objSearcher = new ManagementObjectSearcher(biosQuery);
                var biosName = string.Empty;
                foreach (var obj in objSearcher.Get())
                {
                    biosName = "Bios: " + obj["Name"];
                }

                var machineName = string.Format("Machine name: {0}", Environment.MachineName);
                var userName = string.Format("User: {0}", Environment.UserName);
                var userDomainName = string.Format("Domain: {0}", Environment.UserDomainName);
                var cpuName = string.Format("CPU: {0}", Registry.LocalMachine
                    .OpenSubKey(@"HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")
                    ?.GetValue(@"ProcessorNameString") ?? "no data");
                var monitorSize = string.Format("Display size: Height: {0} Width: {1}",
                    PrimaryMonitorSize.Height, PrimaryMonitorSize.Width);
                var drives = DriveInfo.GetDrives();
                var totalRam = string.Format("RAM: {0}",
                    new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory);

                // PRINT LOG SYSTEM INFO
                sysInfoListView.Items.Add(sysDirectory);
                sysInfoListView.Items.Add(sysRunTime);
                sysInfoListView.Items.Add(sysOsVersion);
                sysInfoListView.Items.Add(sysOsName);
                sysInfoListView.Items.Add(sysOsProductId);
                sysInfoListView.Items.Add(biosName);
                sysInfoListView.Items.Add(machineName);
                sysInfoListView.Items.Add(userName);
                sysInfoListView.Items.Add(userDomainName);
                sysInfoListView.Items.Add(cpuName);
                sysInfoListView.Items.Add(totalRam);

                foreach (var driveName in
                    from drive in drives
                    let driveName = "Disk drive " + drive.Name
                    select driveName + (drive.IsReady
                    ? " Format: " + drive.DriveFormat + " Total size: " + drive.TotalSize
                    : " Drive is not ready"))
                {
                    sysInfoListView.Items.Add(driveName);
                }

                sysInfoListView.Items.Add(monitorSize);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        // SAVE INFO BUTTON CLICK
        //
        private void saveInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var listItems = sysInfoListView.Items;
                if (listItems.Count < 1) throw new ArgumentException("No items to save.");

                var textInfo = listItems
                    .Cast<object>()
                    .Aggregate(string.Empty,
                        (current, item) => current + (item.ToString().Substring(15).Replace("}", "") + "\r\n"));

                File.WriteAllText(@"system-info.txt", textInfo);
                MessageBox.Show(@"Done!");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(@"Run the application as administrator.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        // RESET INFO BUTTON CLICK
        //
        private void resetInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sysInfoListView.Items.Count < 1)
                {
                    throw new ArgumentException("Nothing to reset.");
                }
                sysInfoListView.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //
        // CREDITS MENU
        //
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"System info BETA by Dimitar Dimitrov (IDmitrov)");
        }
        //
        // MAIN MENU ITEM CLICKED
        //
        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //
        // LIST ITEM CONTEXT MENU OPEN
        //
        private void listItemsContexMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            viewOnlineToolStripMenuItem.Enabled = false;

            if (sysInfoListView.Items.Count > 0 && sysInfoListView.FocusedItem.Selected)
            {
                if (sysInfoListView.FocusedItem.Text.ToLower().StartsWith("cpu") 
                    || sysInfoListView.FocusedItem.Text.ToLower().StartsWith("os version")
                    || sysInfoListView.FocusedItem.Text.ToLower().StartsWith("bios"))
                {
                    viewOnlineToolStripMenuItem.Enabled = true;
                }
            }
        }
        //
        // LIST ITEMS CONTEXT MENU VIEW ONLINE MENU
        //
        private void vewOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sysInfoListView.Items.Count > 0)
            {
                if (sysInfoListView.FocusedItem.Text.ToLower().StartsWith("cpu") 
                    || sysInfoListView.FocusedItem.Text.ToLower().StartsWith("os version")
                    || sysInfoListView.FocusedItem.Text.ToLower().StartsWith("bios"))
                {
                    var searchQuery = "https://www.google.com/search?q=" + sysInfoListView.FocusedItem.Text;
                    System.Diagnostics.Process.Start(searchQuery);
                }
            }
        }
    }
}