using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int v = trackBar2.Value;
            if (v == 1)
            {
                label2.Text = "CMD";
                trackBar1.Maximum = 85;
                textBox1.Text = "ASSOC";
            }
            else
            {
                label2.Text = "PowerShell";
                trackBar1.Maximum = 867;
                textBox1.Text = "Add-AppvClientConnectionGroup";
            }    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            if (label2.Text == "PowerShell")
            {
                start.Arguments = "-Command " + textBox1.Text + " " + textBox2.Text;
                if (checkBox2.Checked == true)
                {
                    start.Arguments = "-Command " + textBox1.Text + " " + textBox2.Text + ";exit";
                }
                else
                {
                    start.Arguments = "-Command " + textBox1.Text + " " + textBox2.Text;
                }
            }
            else
            {
                if (checkBox2.Checked == true)
                {
                    start.Arguments = "/c " + textBox1.Text + " " + textBox2.Text;
                }
                else
                {
                    start.Arguments = "/k " + textBox1.Text + " " + textBox2.Text;
                }
            }
            start.FileName = label2.Text + ".exe";
            if (checkBox3.Checked == true)
            {
                start.WindowStyle = ProcessWindowStyle.Hidden;
            }
            else
            {
                start.WindowStyle = ProcessWindowStyle.Normal;
            }    
            if (checkBox1.Checked == true)
            {
                start.Verb = "RunAs";
            }
            start.CreateNoWindow = true;
            int exitCode;

            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();
                exitCode = proc.ExitCode;
            }

            Application.Exit();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int v = trackBar3.Value;
            if (v == 1)
            {
                button1.Text = "Run";
            }
            else
            {
                button1.Text = "Type";
            }
        }

            private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int v = trackBar2.Value;
            int c = trackBar1.Value;
            if (v == 1)
            {
                if (c == 1)
                {
                    textBox1.Text = "ASSOC";
                }
                else if (c == 2)
                {
                    textBox1.Text = "ATTRIB";
                }
                else if (c == 3)
                {
                    textBox1.Text = "BREAK";
                }
                else if (c == 4)
                {
                    textBox1.Text = "BCDEDIT";
                }
                else if (c == 5)
                {
                    textBox1.Text = "CACLS";
                }
                else if (c == 6)
                {
                    textBox1.Text = "CALL";
                }
                else if (c == 7)
                {
                    textBox1.Text = "CD";
                }
                else if (c == 8)
                {
                    textBox1.Text = "CHCP";
                }
                else if (c == 9)
                {
                    textBox1.Text = "CHDIR";
                }
                else if (c == 10)
                {
                    textBox1.Text = "CHKDSK";
                }
                else if (c == 11)
                {
                    textBox1.Text = "CHKNTFS";
                }
                else if (c == 12)
                {
                    textBox1.Text = "CLS";
                }
                else if (c == 13)
                {
                    textBox1.Text = "CMD";
                }
                else if (c == 14)
                {
                    textBox1.Text = "COLOR";
                }
                else if (c == 15)
                {
                    textBox1.Text = "COMP";
                }
                else if (c == 16)
                {
                    textBox1.Text = "COMPACT";
                }
                else if (c == 17)
                {
                    textBox1.Text = "CONVERT";
                }
                else if (c == 18)
                {
                    textBox1.Text = "COPY";
                }
                else if (c == 19)
                {
                    textBox1.Text = "DATE";
                }
                else if (c == 20)
                {
                    textBox1.Text = "DEL";
                }
                else if (c == 21)
                {
                    textBox1.Text = "DIR";
                }
                else if (c == 22)
                {
                    textBox1.Text = "DISKPART";
                }
                else if (c == 23)
                {
                    textBox1.Text = "DOSKEY";
                }
                else if (c == 24)
                {
                    textBox1.Text = "DRIVERQUERY";
                }
                else if (c == 25)
                {
                    textBox1.Text = "ECHO";
                }
                else if (c == 26)
                {
                    textBox1.Text = "ENDLOCAL";
                }
                else if (c == 27)
                {
                    textBox1.Text = "ERASE";
                }
                else if (c == 28)
                {
                    textBox1.Text = "EXIT";
                }
                else if (c == 29)
                {
                    textBox1.Text = "FC";
                }
                else if (c == 30)
                {
                    textBox1.Text = "FIND";
                }
                else if (c == 31)
                {
                    textBox1.Text = "FINDSTR";
                }
                else if (c == 32)
                {
                    textBox1.Text = "FOR";
                }
                else if (c == 33)
                {
                    textBox1.Text = "FORMAT";
                }
                else if (c == 34)
                {
                    textBox1.Text = "FSUTIL";
                }
                else if (c == 35)
                {
                    textBox1.Text = "FTYPE";
                }
                else if (c == 36)
                {
                    textBox1.Text = "GOTO";
                }
                else if (c == 37)
                {
                    textBox1.Text = "GPRESULT";
                }
                else if (c == 38)
                {
                    textBox1.Text = "GRAFTABL";
                }
                else if (c == 39)
                {
                    textBox1.Text = "HELP";
                }
                else if (c == 40)
                {
                    textBox1.Text = "ICACLS";
                }
                else if (c == 41)
                {
                    textBox1.Text = "IF";
                }
                else if (c == 42)
                {
                    textBox1.Text = "LABEL";
                }
                else if (c == 43)
                {
                    textBox1.Text = "MD";
                }
                else if (c == 44)
                {
                    textBox1.Text = "MKDIR";
                }
                else if (c == 45)
                {
                    textBox1.Text = "MKLINK";
                }
                else if (c == 46)
                {
                    textBox1.Text = "MODE";
                }
                else if (c == 47)
                {
                    textBox1.Text = "MORE";
                }
                else if (c == 48)
                {
                    textBox1.Text = "MOVE";
                }
                else if (c == 49)
                {
                    textBox1.Text = "OPENFILES";
                }
                else if (c == 50)
                {
                    textBox1.Text = "PATH";
                }
                else if (c == 51)
                {
                    textBox1.Text = "PAUSE";
                }
                else if (c == 52)
                {
                    textBox1.Text = "POPD";
                }
                else if (c == 53)
                {
                    textBox1.Text = "PUSHD";
                }
                else if (c == 54)
                {
                    textBox1.Text = "PRINT";
                }
                else if (c == 55)
                {
                    textBox1.Text = "PROMPT";
                }
                else if (c == 56)
                {
                    textBox1.Text = "PUSHD";
                }
                else if (c == 57)
                {
                    textBox1.Text = "RD";
                }
                else if (c == 58)
                {
                    textBox1.Text = "RECOVER";
                }
                else if (c == 59)
                {
                    textBox1.Text = "REM";
                }
                else if (c == 60)
                {
                    textBox1.Text = "REN";
                }
                else if (c == 61)
                {
                    textBox1.Text = "RENAME";
                }
                else if (c == 62)
                {
                    textBox1.Text = "REPLACE";
                }
                else if (c == 63)
                {
                    textBox1.Text = "RMDIR";
                }
                else if (c == 64)
                {
                    textBox1.Text = "ROBOCOPY";
                }
                else if (c == 65)
                {
                    textBox1.Text = "SET";
                }
                else if (c == 66)
                {
                    textBox1.Text = "SETLOCAL";
                }
                else if (c == 67)
                {
                    textBox1.Text = "SC";
                }
                else if (c == 68)
                {
                    textBox1.Text = "SCHTASKS";
                }
                else if (c == 69)
                {
                    textBox1.Text = "SHIFT";
                }
                else if (c == 70)
                {
                    textBox1.Text = "SHUTDOWN";
                }
                else if (c == 71)
                {
                    textBox1.Text = "SORT";
                }
                else if (c == 72)
                {
                    textBox1.Text = "START";
                }
                else if (c == 73)
                {
                    textBox1.Text = "SUBST";
                }
                else if (c == 74)
                {
                    textBox1.Text = "SYSTEMINFO";
                }
                else if (c == 75)
                {
                    textBox1.Text = "TASKLIST";
                }
                else if (c == 76)
                {
                    textBox1.Text = "TASKKILL";
                }
                else if (c == 77)
                {
                    textBox1.Text = "TIME";
                }
                else if (c == 78)
                {
                    textBox1.Text = "TITLE";
                }
                else if (c == 79)
                {
                    textBox1.Text = "TREE";
                }
                else if (c == 80)
                {
                    textBox1.Text = "TYPE";
                }
                else if (c == 81)
                {
                    textBox1.Text = "VER";
                }
                else if (c == 82)
                {
                    textBox1.Text = "VERIFY";
                }
                else if (c == 83)
                {
                    textBox1.Text = "VOL";
                }
                else if (c == 84)
                {
                    textBox1.Text = "XCOPY";
                }
                else if (c == 85)
                {
                    textBox1.Text = "WMIC";
                }
            }
            else
            {
                if (c == 1)
                {
                    textBox1.Text = "Add-AppvClientConnectionGroup";
                }
                else if (c == 2)
                {
                    textBox1.Text = "Add-AppvClientPackage";
                }
                else if (c == 3)
                {
                    textBox1.Text = "Add-AppvPublishingServer";
                }
                else if (c == 4)
                {
                    textBox1.Text = "Add-AppxPackage";
                }
                else if (c == 5)
                {
                    textBox1.Text = "Add-AppxProvisionedPackage";
                }
                else if (c == 6)
                {
                    textBox1.Text = "Add-AppxVolume";
                }
                else if (c == 7)
                {
                    textBox1.Text = "Add-BitsFile";
                }
                else if (c == 8)
                {
                    textBox1.Text = "Add-CertificateEnrollmentPolicyServer";
                }
                else if (c == 9)
                {
                    textBox1.Text = "Add-Computer";
                }
                else if (c == 10)
                {
                    textBox1.Text = "Add-Content";
                }
                else if (c == 11)
                {
                    textBox1.Text = "Add-History";
                }
                else if (c == 12)
                {
                    textBox1.Text = "Add-JobTrigger";
                }
                else if (c == 13)
                {
                    textBox1.Text = "Add-KdsRootKey";
                }
                else if (c == 14)
                {
                    textBox1.Text = "Add-LocalGroupMember";
                }
                else if (c == 15)
                {
                    textBox1.Text = "Add-Member";
                }
                else if (c == 16)
                {
                    textBox1.Text = "Add-PSSnapin";
                }
                else if (c == 17)
                {
                    textBox1.Text = "Add-SignerRule";
                }
                else if (c == 18)
                {
                    textBox1.Text = "Add-Type";
                }
                else if (c == 19)
                {
                    textBox1.Text = "Add-VMAssignableDevice";
                }
                else if (c == 20)
                {
                    textBox1.Text = "Add-VMDvdDrive";
                }
                else if (c == 21)
                {
                    textBox1.Text = "Add-VMFibreChannelHba";
                }
                else if (c == 22)
                {
                    textBox1.Text = "Add-VMGpuPartitionAdapter";
                }
                else if (c == 23)
                {
                    textBox1.Text = "Add-VMGroupMember";
                }
                else if (c == 24)
                {
                    textBox1.Text = "Add-VMHardDiskDrive";
                }
                else if (c == 25)
                {
                    textBox1.Text = "Add-VMHostAssignableDevice";
                }
                else if (c == 26)
                {
                    textBox1.Text = "Add-VMKeyStorageDrive";
                }
                else if (c == 27)
                {
                    textBox1.Text = "Add-VMMigrationNetwork";
                }
                else if (c == 28)
                {
                    textBox1.Text = "Add-VMNetworkAdapter";
                }
                else if (c == 29)
                {
                    textBox1.Text = "Add-VMNetworkAdapterAcl";
                }
                else if (c == 30)
                {
                    textBox1.Text = "Add-VMNetworkAdapterExtendedAcl";
                }
                else if (c == 31)
                {
                    textBox1.Text = "Add-VMNetworkAdapterRoutingDomainMapping";
                }
                else if (c == 32)
                {
                    textBox1.Text = "Add-VMPmemController";
                }
                else if (c == 33)
                {
                    textBox1.Text = "Add-VMRemoteFx3dVideoAdapter";
                }
                else if (c == 34)
                {
                    textBox1.Text = "Add-VMScsiController";
                }
                else if (c == 35)
                {
                    textBox1.Text = "Add-VMStoragePath";
                }
                else if (c == 36)
                {
                    textBox1.Text = "Add-VMSwitch";
                }
                else if (c == 37)
                {
                    textBox1.Text = "Add-VMSwitchExtensionPortFeature";
                }
                else if (c == 38)
                {
                    textBox1.Text = "Add-VMSwitchExtensionSwitchFeature";
                }
                else if (c == 39)
                {
                    textBox1.Text = "Add-VMSwitchTeamMember";
                }
                else if (c == 40)
                {
                    textBox1.Text = "Add-WindowsCapability";
                }
                else if (c == 41)
                {
                    textBox1.Text = "Add-WindowsDriver";
                }
                else if (c == 42)
                {
                    textBox1.Text = "Add-WindowsImage";
                }
                else if (c == 43)
                {
                    textBox1.Text = "Add-WindowsPackage";
                }
                else if (c == 44)
                {
                    textBox1.Text = "Checkpoint-Computer";
                }
                else if (c == 45)
                {
                    textBox1.Text = "Checkpoint-VM";
                }
                else if (c == 46)
                {
                    textBox1.Text = "Clear-Content";
                }
                else if (c == 47)
                {
                    textBox1.Text = "Clear-EventLog";
                }
                else if (c == 48)
                {
                    textBox1.Text = "Clear-History";
                }
                else if (c == 49)
                {
                    textBox1.Text = "Clear-Item";
                }
                else if (c == 50)
                {
                    textBox1.Text = "Clear-ItemProperty";
                }
                else if (c == 51)
                {
                    textBox1.Text = "Clear-KdsCache";
                }
                else if (c == 52)
                {
                    textBox1.Text = "Clear-RecycleBin";
                }
                else if (c == 53)
                {
                    textBox1.Text = "Clear-Tpm";
                }
                else if (c == 54)
                {
                    textBox1.Text = "Clear-UevAppxPackage";
                }
                else if (c == 55)
                {
                    textBox1.Text = "Clear-UevConfiguration";
                }
                else if (c == 56)
                {
                    textBox1.Text = "Clear-Variable";
                }
                else if (c == 57)
                {
                    textBox1.Text = "Clear-WindowsCorruptMountPoint";
                }
                else if (c == 58)
                {
                    textBox1.Text = "Compare-Object";
                }
                else if (c == 59)
                {
                    textBox1.Text = "Compare-VM";
                }
                else if (c == 60)
                {
                    textBox1.Text = "Complete-BitsTransfer";
                }
                else if (c == 61)
                {
                    textBox1.Text = "Complete-DtcDiagnosticTransaction";
                }
                else if (c == 62)
                {
                    textBox1.Text = "Complete-Transaction";
                }
                else if (c == 63)
                {
                    textBox1.Text = "Complete-VMFailover";
                }
                else if (c == 64)
                {
                    textBox1.Text = "Confirm-SecureBootUEFI";
                }
                else if (c == 65)
                {
                    textBox1.Text = "Connect-PSSession";
                }
                else if (c == 66)
                {
                    textBox1.Text = "Connect-VMNetworkAdapter";
                }
                else if (c == 67)
                {
                    textBox1.Text = "Connect-VMSan";
                }
                else if (c == 68)
                {
                    textBox1.Text = "Connect-WSMan";
                }
                else if (c == 69)
                {
                    textBox1.Text = "ConvertFrom-CIPolicy";
                }
                else if (c == 70)
                {
                    textBox1.Text = "ConvertFrom-Csv";
                }
                else if (c == 71)
                {
                    textBox1.Text = "ConvertFrom-Json";
                }
                else if (c == 72)
                {
                    textBox1.Text = "ConvertFrom-SecureString";
                }
                else if (c == 73)
                {
                    textBox1.Text = "ConvertFrom-String";
                }
                else if (c == 74)
                {
                    textBox1.Text = "ConvertFrom-StringData";
                }
                else if (c == 75)
                {
                    textBox1.Text = "Convert-Path";
                }
                else if (c == 76)
                {
                    textBox1.Text = "Convert-String";
                }
                else if (c == 77)
                {
                    textBox1.Text = "ConvertTo-Csv";
                }
                else if (c == 78)
                {
                    textBox1.Text = "ConvertTo-Html";
                }
                else if (c == 79)
                {
                    textBox1.Text = "ConvertTo-Json";
                }
                else if (c == 80)
                {
                    textBox1.Text = "ConvertTo-ProcessMitigationPolicy";
                }
                else if (c == 81)
                {
                    textBox1.Text = "ConvertTo-SecureString";
                }
                else if (c == 82)
                {
                    textBox1.Text = "ConvertTo-TpmOwnerAuth";
                }
                else if (c == 83)
                {
                    textBox1.Text = "ConvertTo-Xml";
                }
                else if (c == 84)
                {
                    textBox1.Text = "Convert-VHD";
                }
                else if (c == 85)
                {
                    textBox1.Text = "Copy-Item";
                }
                else if (c == 86)
                {
                    textBox1.Text = "Copy-ItemProperty";
                }
                else if (c == 87)
                {
                    textBox1.Text = "Copy-VMFile";
                }
                else if (c == 88)
                {
                    textBox1.Text = "Debug-Job";
                }
                else if (c == 89)
                {
                    textBox1.Text = "Debug-Process";
                }
                else if (c == 90)
                {
                    textBox1.Text = "Debug-Runspace";
                }
                else if (c == 91)
                {
                    textBox1.Text = "Debug-VM";
                }
                else if (c == 92)
                {
                    textBox1.Text = "Delete-DeliveryOptimizationCache";
                }
                else if (c == 93)
                {
                    textBox1.Text = "Disable-AppBackgroundTaskDiagnosticLog";
                }
                else if (c == 94)
                {
                    textBox1.Text = "Disable-Appv";
                }
                else if (c == 95)
                {
                    textBox1.Text = "Disable-AppvClientConnectionGroup";
                }
                else if (c == 96)
                {
                    textBox1.Text = "Disable-ComputerRestore";
                }
                else if (c == 97)
                {
                    textBox1.Text = "Disable-JobTrigger";
                }
                else if (c == 98)
                {
                    textBox1.Text = "Disable-LocalUser";
                }
                else if (c == 99)
                {
                    textBox1.Text = "Disable-PSBreakpoint";
                }
                else if (c == 100)
                {
                    textBox1.Text = "Disable-PSRemoting";
                }
                else if (c == 101)
                {
                    textBox1.Text = "Disable-PSSessionConfiguration";
                }
                else if (c == 102)
                {
                    textBox1.Text = "Disable-RunspaceDebug";
                }
                else if (c == 103)
                {
                    textBox1.Text = "Disable-ScheduledJob";
                }
                else if (c == 104)
                {
                    textBox1.Text = "Disable-TlsCipherSuite";
                }
                else if (c == 105)
                {
                    textBox1.Text = "Disable-TlsEccCurve";
                }
                else if (c == 106)
                {
                    textBox1.Text = "Disable-TlsSessionTicketKey";
                }
                else if (c == 107)
                {
                    textBox1.Text = "Disable-TpmAutoProvisioning";
                }
                else if (c == 108)
                {
                    textBox1.Text = "Disable-Uev";
                }
                else if (c == 109)
                {
                    textBox1.Text = "Disable-UevAppxPackage";
                }
                else if (c == 110)
                {
                    textBox1.Text = "Disable-UevTemplate";
                }
                else if (c == 111)
                {
                    textBox1.Text = "Disable-VMConsoleSupport";
                }
                else if (c == 112)
                {
                    textBox1.Text = "Disable-VMEventing";
                }
                else if (c == 113)
                {
                    textBox1.Text = "Disable-VMIntegrationService";
                }
                else if (c == 114)
                {
                    textBox1.Text = "Disable-VMMigration";
                }
                else if (c == 115)
                {
                    textBox1.Text = "Disable-VMRemoteFXPhysicalVideoAdapter";
                }
                else if (c == 116)
                {
                    textBox1.Text = "Disable-VMResourceMetering";
                }
                else if (c == 117)
                {
                    textBox1.Text = "Disable-VMSwitchExtension";
                }
                else if (c == 118)
                {
                    textBox1.Text = "Disable-VMTPM";
                }
                else if (c == 119)
                {
                    textBox1.Text = "Disable-WindowsErrorReporting";
                }
                else if (c == 120)
                {
                    textBox1.Text = "Disable-WindowsOptionalFeature";
                }
                else if (c == 121)
                {
                    textBox1.Text = "Disable-WSManCredSSP";
                }
                else if (c == 122)
                {
                    textBox1.Text = "Disconnect-PSSession";
                }
                else if (c == 123)
                {
                    textBox1.Text = "Disconnect-VMNetworkAdapter";
                }
                else if (c == 124)
                {
                    textBox1.Text = "Disconnect-VMSan";
                }
                else if (c == 125)
                {
                    textBox1.Text = "Disconnect-WSMan";
                }
                else if (c == 126)
                {
                    textBox1.Text = "Dismount-AppxVolume";
                }
                else if (c == 127)
                {
                    textBox1.Text = "Dismount-VHD";
                }
                else if (c == 128)
                {
                    textBox1.Text = "Dismount-VMHostAssignableDevice";
                }
                else if (c == 129)
                {
                    textBox1.Text = "Dismount-WindowsImage";
                }
                else if (c == 130)
                {
                    textBox1.Text = "Edit-CIPolicyRule";
                }
                else if (c == 131)
                {
                    textBox1.Text = "Enable-AppBackgroundTaskDiagnosticLog";
                }
                else if (c == 132)
                {
                    textBox1.Text = "Enable-Appv";
                }
                else if (c == 133)
                {
                    textBox1.Text = "Enable-AppvClientConnectionGroup";
                }
                else if (c == 134)
                {
                    textBox1.Text = "Enable-ComputerRestore";
                }
                else if (c == 135)
                {
                    textBox1.Text = "Enable-JobTrigger";
                }
                else if (c == 136)
                {
                    textBox1.Text = "Enable-LocalUser";
                }
                else if (c == 137)
                {
                    textBox1.Text = "Enable-PSBreakpoint";
                }
                else if (c == 138)
                {
                    textBox1.Text = "Enable-PSRemoting";
                }
                else if (c == 139)
                {
                    textBox1.Text = "Enable-PSSessionConfiguration";
                }
                else if (c == 140)
                {
                    textBox1.Text = "Enable-RunspaceDebug";
                }
                else if (c == 141)
                {
                    textBox1.Text = "Enable-ScheduledJob";
                }
                else if (c == 142)
                {
                    textBox1.Text = "Enable-TlsCipherSuite";
                }
                else if (c == 143)
                {
                    textBox1.Text = "Enable-TlsEccCurve";
                }
                else if (c == 144)
                {
                    textBox1.Text = "Enable-TlsSessionTicketKey";
                }
                else if (c == 145)
                {
                    textBox1.Text = "Enable-TpmAutoProvisioning";
                }
                else if (c == 146)
                {
                    textBox1.Text = "Enable-Uev";
                }
                else if (c == 147)
                {
                    textBox1.Text = "Enable-UevAppxPackage";
                }
                else if (c == 148)
                {
                    textBox1.Text = "Enable-UevTemplate";
                }
                else if (c == 149)
                {
                    textBox1.Text = "Enable-VMConsoleSupport";
                }
                else if (c == 150)
                {
                    textBox1.Text = "Enable-VMEventing";
                }
                else if (c == 151)
                {
                    textBox1.Text = "Enable-VMIntegrationService";
                }
                else if (c == 152)
                {
                    textBox1.Text = "Enable-VMMigration";
                }
                else if (c == 153)
                {
                    textBox1.Text = "Enable-VMRemoteFXPhysicalVideoAdapter";
                }
                else if (c == 154)
                {
                    textBox1.Text = "Enable-VMReplication";
                }
                else if (c == 155)
                {
                    textBox1.Text = "Enable-VMResourceMetering";
                }
                else if (c == 156)
                {
                    textBox1.Text = "Enable-VMSwitchExtension";
                }
                else if (c == 157)
                {
                    textBox1.Text = "Enable-VMTPM";
                }
                else if (c == 158)
                {
                    textBox1.Text = "Enable-WindowsErrorReporting";
                }
                else if (c == 159)
                {
                    textBox1.Text = "Enable-WindowsOptionalFeature";
                }
                else if (c == 160)
                {
                    textBox1.Text = "Enable-WSManCredSSP";
                }
                else if (c == 161)
                {
                    textBox1.Text = "Enter-PSHostProcess";
                }
                else if (c == 162)
                {
                    textBox1.Text = "Enter-PSSession";
                }
                else if (c == 163)
                {
                    textBox1.Text = "Exit-PSHostProcess";
                }
                else if (c == 164)
                {
                    textBox1.Text = "Exit-PSSession";
                }
                else if (c == 165)
                {
                    textBox1.Text = "Expand-WindowsCustomDataImage";
                }
                else if (c == 166)
                {
                    textBox1.Text = "Expand-WindowsImage";
                }
                else if (c == 167)
                {
                    textBox1.Text = "Export-Alias";
                }
                else if (c == 168)
                {
                    textBox1.Text = "Export-BinaryMiLog";
                }
                else if (c == 169)
                {
                    textBox1.Text = "Export-Certificate";
                }
                else if (c == 170)
                {
                    textBox1.Text = "Export-Clixml";
                }
                else if (c == 171)
                {
                    textBox1.Text = "Export-Console";
                }
                else if (c == 172)
                {
                    textBox1.Text = "Export-Counter";
                }
                else if (c == 173)
                {
                    textBox1.Text = "Export-Csv";
                }
                else if (c == 174)
                {
                    textBox1.Text = "Export-FormatData";
                }
                else if (c == 175)
                {
                    textBox1.Text = "Export-ModuleMember";
                }
                else if (c == 176)
                {
                    textBox1.Text = "Export-PfxCertificate";
                }
                else if (c == 177)
                {
                    textBox1.Text = "Export-ProvisioningPackage";
                }
                else if (c == 178)
                {
                    textBox1.Text = "Export-PSSession";
                }
                else if (c == 179)
                {
                    textBox1.Text = "Export-StartLayout";
                }
                else if (c == 180)
                {
                    textBox1.Text = "Export-StartLayoutEdgeAssets";
                }
                else if (c == 181)
                {
                    textBox1.Text = "Export-TlsSessionTicketKey";
                }
                else if (c == 182)
                {
                    textBox1.Text = "Export-Trace";
                }
                else if (c == 183)
                {
                    textBox1.Text = "Export-UevConfiguration";
                }
                else if (c == 184)
                {
                    textBox1.Text = "Export-UevPackage";
                }
                else if (c == 185)
                {
                    textBox1.Text = "Export-VM";
                }
                else if (c == 186)
                {
                    textBox1.Text = "Export-VMSnapshot";
                }
                else if (c == 187)
                {
                    textBox1.Text = "Export-WindowsCapabilitySource";
                }
                else if (c == 188)
                {
                    textBox1.Text = "Export-WindowsDriver";
                }
                else if (c == 189)
                {
                    textBox1.Text = "Export-WindowsImage";
                }
                else if (c == 190)
                {
                    textBox1.Text = "Find-Package";
                }
                else if (c == 191)
                {
                    textBox1.Text = "Find-PackageProvider";
                }
                else if (c == 192)
                {
                    textBox1.Text = "ForEach-Object";
                }
                else if (c == 193)
                {
                    textBox1.Text = "Format-Custom";
                }
                else if (c == 194)
                {
                    textBox1.Text = "Format-List";
                }
                else if (c == 195)
                {
                    textBox1.Text = "Format-SecureBootUEFI";
                }
                else if (c == 196)
                {
                    textBox1.Text = "Format-Table";
                }
                else if (c == 197)
                {
                    textBox1.Text = "Format-Wide";
                }
                else if (c == 198)
                {
                    textBox1.Text = "Get-Acl";
                }
                else if (c == 199)
                {
                    textBox1.Text = "Get-Alias";
                }
                else if (c == 200)
                {
                    textBox1.Text = "Get-AppLockerFileInformation";
                }
                else if (c == 201)
                {
                    textBox1.Text = "Get-AppLockerPolicy";
                }
                else if (c == 202)
                {
                    textBox1.Text = "Get-AppvClientApplication";
                }
                else if (c == 203)
                {
                    textBox1.Text = "Get-AppvClientConfiguration";
                }
                else if (c == 204)
                {
                    textBox1.Text = "Get-AppvClientConnectionGroup";
                }
                else if (c == 205)
                {
                    textBox1.Text = "Get-AppvClientMode";
                }
                else if (c == 206)
                {
                    textBox1.Text = "Get-AppvClientPackage";
                }
                else if (c == 207)
                {
                    textBox1.Text = "Get-AppvPublishingServer";
                }
                else if (c == 208)
                {
                    textBox1.Text = "Get-AppvStatus";
                }
                else if (c == 209)
                {
                    textBox1.Text = "Get-AppxDefaultVolume";
                }
                else if (c == 210)
                {
                    textBox1.Text = "Get-AppxPackage";
                }
                else if (c == 211)
                {
                    textBox1.Text = "Get-AppxPackageManifest";
                }
                else if (c == 212)
                {
                    textBox1.Text = "Get-AppxProvisionedPackage";
                }
                else if (c == 213)
                {
                    textBox1.Text = "Get-AppxVolume";
                }
                else if (c == 214)
                {
                    textBox1.Text = "Get-AuthenticodeSignature";
                }
                else if (c == 215)
                {
                    textBox1.Text = "Get-BitsTransfer";
                }
                else if (c == 216)
                {
                    textBox1.Text = "Get-Certificate";
                }
                else if (c == 217)
                {
                    textBox1.Text = "Get-CertificateAutoEnrollmentPolicy";
                }
                else if (c == 218)
                {
                    textBox1.Text = "Get-CertificateEnrollmentPolicyServer";
                }
                else if (c == 219)
                {
                    textBox1.Text = "Get-CertificateNotificationTask";
                }
                else if (c == 220)
                {
                    textBox1.Text = "Get-ChildItem";
                }
                else if (c == 221)
                {
                    textBox1.Text = "Get-CimAssociatedInstance";
                }
                else if (c == 222)
                {
                    textBox1.Text = "Get-CimClass";
                }
                else if (c == 223)
                {
                    textBox1.Text = "Get-CimInstance";
                }
                else if (c == 224)
                {
                    textBox1.Text = "Get-CimSession";
                }
                else if (c == 225)
                {
                    textBox1.Text = "Get-CIPolicy";
                }
                else if (c == 226)
                {
                    textBox1.Text = "Get-CIPolicyIdInfo";
                }
                else if (c == 227)
                {
                    textBox1.Text = "Get-CIPolicyInfo";
                }
                else if (c == 228)
                {
                    textBox1.Text = "Get-Clipboard";
                }
                else if (c == 229)
                {
                    textBox1.Text = "Get-CmsMessage";
                }
                else if (c == 230)
                {
                    textBox1.Text = "Get-Command";
                }
                else if (c == 231)
                {
                    textBox1.Text = "Get-ComputerInfo";
                }
                else if (c == 232)
                {
                    textBox1.Text = "Get-ComputerRestorePoint";
                }
                else if (c == 233)
                {
                    textBox1.Text = "Get-Content";
                }
                else if (c == 234)
                {
                    textBox1.Text = "Get-ControlPanelItem";
                }
                else if (c == 235)
                {
                    textBox1.Text = "Get-Counter";
                }
                else if (c == 236)
                {
                    textBox1.Text = "Get-Credential";
                }
                else if (c == 237)
                {
                    textBox1.Text = "Get-Culture";
                }
                else if (c == 238)
                {
                    textBox1.Text = "Get-DAPolicyChange";
                }
                else if (c == 239)
                {
                    textBox1.Text = "Get-Date";
                }
                else if (c == 240)
                {
                    textBox1.Text = "Get-DeliveryOptimizationLog";
                }
                else if (c == 241)
                {
                    textBox1.Text = "Get-DeliveryOptimizationLogAnalysis";
                }
                else if (c == 242)
                {
                    textBox1.Text = "Get-Event";
                }
                else if (c == 243)
                {
                    textBox1.Text = "Get-EventLog";
                }
                else if (c == 244)
                {
                    textBox1.Text = "Get-EventSubscriber";
                }
                else if (c == 245)
                {
                    textBox1.Text = "Get-ExecutionPolicy";
                }
                else if (c == 246)
                {
                    textBox1.Text = "Get-FormatData";
                }
                else if (c == 247)
                {
                    textBox1.Text = "Get-Help";
                }
                else if (c == 248)
                {
                    textBox1.Text = "Get-HgsAttestationBaselinePolicy";
                }
                else if (c == 249)
                {
                    textBox1.Text = "Get-HgsTrace";
                }
                else if (c == 250)
                {
                    textBox1.Text = "Get-HgsTraceFileData";
                }
                else if (c == 251)
                {
                    textBox1.Text = "Get-History";
                }
                else if (c == 252)
                {
                    textBox1.Text = "Get-Host";
                }
                else if (c == 253)
                {
                    textBox1.Text = "Get-HotFix";
                }
                else if (c == 254)
                {
                    textBox1.Text = "Get-Item";
                }
                else if (c == 255)
                {
                    textBox1.Text = "Get-ItemProperty";
                }
                else if (c == 256)
                {
                    textBox1.Text = "Get-ItemPropertyValue";
                }
                else if (c == 257)
                {
                    textBox1.Text = "Get-Job";
                }
                else if (c == 258)
                {
                    textBox1.Text = "Get-JobTrigger";
                }
                else if (c == 259)
                {
                    textBox1.Text = "Get-KdsConfiguration";
                }
                else if (c == 260)
                {
                    textBox1.Text = "Get-KdsRootKey";
                }
                else if (c == 261)
                {
                    textBox1.Text = "Get-LocalGroup";
                }
                else if (c == 262)
                {
                    textBox1.Text = "Get-LocalGroupMember";
                }
                else if (c == 263)
                {
                    textBox1.Text = "Get-LocalUser";
                }
                else if (c == 264)
                {
                    textBox1.Text = "Get-Location";
                }
                else if (c == 265)
                {
                    textBox1.Text = "Get-Member";
                }
                else if (c == 266)
                {
                    textBox1.Text = "Get-Module";
                }
                else if (c == 267)
                {
                    textBox1.Text = "Get-NonRemovableAppsPolicy";
                }
                else if (c == 268)
                {
                    textBox1.Text = "Get-Package";
                }
                else if (c == 269)
                {
                    textBox1.Text = "Get-PackageProvider";
                }
                else if (c == 270)
                {
                    textBox1.Text = "Get-PackageSource";
                }
                else if (c == 271)
                {
                    textBox1.Text = "Get-PfxCertificate";
                }
                else if (c == 272)
                {
                    textBox1.Text = "Get-PfxData";
                }
                else if (c == 273)
                {
                    textBox1.Text = "Get-PmemDisk";
                }
                else if (c == 274)
                {
                    textBox1.Text = "Get-PmemPhysicalDevice";
                }
                else if (c == 275)
                {
                    textBox1.Text = "Get-PmemUnusedRegion";
                }
                else if (c == 276)
                {
                    textBox1.Text = "Get-Process";
                }
                else if (c == 277)
                {
                    textBox1.Text = "Get-ProcessMitigation";
                }
                else if (c == 278)
                {
                    textBox1.Text = "Get-ProvisioningPackage";
                }
                else if (c == 279)
                {
                    textBox1.Text = "Get-PSBreakpoint";
                }
                else if (c == 280)
                {
                    textBox1.Text = "Get-PSCallStack";
                }
                else if (c == 281)
                {
                    textBox1.Text = "Get-PSDrive";
                }
                else if (c == 282)
                {
                    textBox1.Text = "Get-PSHostProcessInfo";
                }
                else if (c == 283)
                {
                    textBox1.Text = "Get-PSProvider";
                }
                else if (c == 284)
                {
                    textBox1.Text = "Get-PSReadLineKeyHandler";
                }
                else if (c == 285)
                {
                    textBox1.Text = "Get-PSReadLineOption";
                }
                else if (c == 286)
                {
                    textBox1.Text = "Get-PSSession";
                }
                else if (c == 287)
                {
                    textBox1.Text = "Get-PSSessionCapability";
                }
                else if (c == 288)
                {
                    textBox1.Text = "Get-PSSessionConfiguration";
                }
                else if (c == 289)
                {
                    textBox1.Text = "Get-PSSnapin";
                }
                else if (c == 290)
                {
                    textBox1.Text = "Get-Random";
                }
                else if (c == 291)
                {
                    textBox1.Text = "Get-Runspace";
                }
                else if (c == 292)
                {
                    textBox1.Text = "Get-RunspaceDebug";
                }
                else if (c == 293)
                {
                    textBox1.Text = "Get-ScheduledJob";
                }
                else if (c == 294)
                {
                    textBox1.Text = "Get-ScheduledJobOption";
                }
                else if (c == 295)
                {
                    textBox1.Text = "Get-SecureBootPolicy";
                }
                else if (c == 296)
                {
                    textBox1.Text = "Get-SecureBootUEFI";
                }
                else if (c == 297)
                {
                    textBox1.Text = "Get-Service";
                }
                else if (c == 298)
                {
                    textBox1.Text = "Get-SystemDriver";
                }
                else if (c == 299)
                {
                    textBox1.Text = "Get-TimeZone";
                }
                else if (c == 300)
                {
                    textBox1.Text = "Get-TlsCipherSuite";
                }
                else if (c == 301)
                {
                    textBox1.Text = "Get-TlsEccCurve";
                }
                else if (c == 302)
                {
                    textBox1.Text = "Get-Tpm";
                }
                else if (c == 303)
                {
                    textBox1.Text = "Get-TpmEndorsementKeyInfo";
                }
                else if (c == 304)
                {
                    textBox1.Text = "Get-TpmSupportedFeature";
                }
                else if (c == 305)
                {
                    textBox1.Text = "Get-TraceSource";
                }
                else if (c == 306)
                {
                    textBox1.Text = "Get-Transaction";
                }
                else if (c == 307)
                {
                    textBox1.Text = "Get-TroubleshootingPack";
                }
                else if (c == 308)
                {
                    textBox1.Text = "Get-TrustedProvisioningCertificate";
                }
                else if (c == 309)
                {
                    textBox1.Text = "Get-TypeData";
                }
                else if (c == 310)
                {
                    textBox1.Text = "Get-UevAppxPackage";
                }
                else if (c == 311)
                {
                    textBox1.Text = "Get-UevConfiguration";
                }
                else if (c == 312)
                {
                    textBox1.Text = "Get-UevStatus";
                }
                else if (c == 313)
                {
                    textBox1.Text = "Get-UevTemplate";
                }
                else if (c == 314)
                {
                    textBox1.Text = "Get-UevTemplateProgram";
                }
                else if (c == 315)
                {
                    textBox1.Text = "Get-UICulture";
                }
                else if (c == 316)
                {
                    textBox1.Text = "Get-Unique";
                }
                else if (c == 317)
                {
                    textBox1.Text = "Get-Variable";
                }
                else if (c == 318)
                {
                    textBox1.Text = "Get-VHD";
                }
                else if (c == 319)
                {
                    textBox1.Text = "Get-VHDSet";
                }
                else if (c == 320)
                {
                    textBox1.Text = "Get-VHDSnapshot";
                }
                else if (c == 321)
                {
                    textBox1.Text = "Get-VM";
                }
                else if (c == 322)
                {
                    textBox1.Text = "Get-VMAssignableDevice";
                }
                else if (c == 323)
                {
                    textBox1.Text = "Get-VMBios";
                }
                else if (c == 324)
                {
                    textBox1.Text = "Get-VMComPort";
                }
                else if (c == 325)
                {
                    textBox1.Text = "Get-VMConnectAccess";
                }
                else if (c == 326)
                {
                    textBox1.Text = "Get-VMDvdDrive";
                }
                else if (c == 327)
                {
                    textBox1.Text = "Get-VMFibreChannelHba";
                }
                else if (c == 328)
                {
                    textBox1.Text = "Get-VMFirmware";
                }
                else if (c == 329)
                {
                    textBox1.Text = "Get-VMFloppyDiskDrive";
                }
                else if (c == 330)
                {
                    textBox1.Text = "Get-VMGpuPartitionAdapter";
                }
                else if (c == 331)
                {
                    textBox1.Text = "Get-VMGroup";
                }
                else if (c == 332)
                {
                    textBox1.Text = "Get-VMHardDiskDrive";
                }
                else if (c == 333)
                {
                    textBox1.Text = "Get-VMHost";
                }
                else if (c == 334)
                {
                    textBox1.Text = "Get-VMHostAssignableDevice";
                }
                else if (c == 335)
                {
                    textBox1.Text = "Get-VMHostCluster";
                }
                else if (c == 336)
                {
                    textBox1.Text = "Get-VMHostNumaNode";
                }
                else if (c == 337)
                {
                    textBox1.Text = "Get-VMHostNumaNodeStatus";
                }
                else if (c == 338)
                {
                    textBox1.Text = "Get-VMHostSupportedVersion";
                }
                else if (c == 339)
                {
                    textBox1.Text = "Get-VMIdeController";
                }
                else if (c == 340)
                {
                    textBox1.Text = "Get-VMIntegrationService";
                }
                else if (c == 341)
                {
                    textBox1.Text = "Get-VMKeyProtector";
                }
                else if (c == 342)
                {
                    textBox1.Text = "Get-VMKeyStorageDrive";
                }
                else if (c == 343)
                {
                    textBox1.Text = "Get-VMMemory";
                }
                else if (c == 344)
                {
                    textBox1.Text = "Get-VMMigrationNetwork";
                }
                else if (c == 345)
                {
                    textBox1.Text = "Get-VMNetworkAdapter";
                }
                else if (c == 346)
                {
                    textBox1.Text = "Get-VMNetworkAdapterAcl";
                }
                else if (c == 347)
                {
                    textBox1.Text = "Get-VMNetworkAdapterExtendedAcl";
                }
                else if (c == 348)
                {
                    textBox1.Text = "Get-VMNetworkAdapterFailoverConfiguration";
                }
                else if (c == 349)
                {
                    textBox1.Text = "Get-VMNetworkAdapterIsolation";
                }
                else if (c == 350)
                {
                    textBox1.Text = "Get-VMNetworkAdapterRdma";
                }
                else if (c == 351)
                {
                    textBox1.Text = "Get-VMNetworkAdapterRoutingDomainMapping";
                }
                else if (c == 352)
                {
                    textBox1.Text = "Get-VMNetworkAdapterTeamMapping";
                }
                else if (c == 353)
                {
                    textBox1.Text = "Get-VMNetworkAdapterVlan";
                }
                else if (c == 354)
                {
                    textBox1.Text = "Get-VMPartitionableGpu";
                }
                else if (c == 355)
                {
                    textBox1.Text = "Get-VMPmemController";
                }
                else if (c == 356)
                {
                    textBox1.Text = "Get-VMProcessor";
                }
                else if (c == 357)
                {
                    textBox1.Text = "Get-VMRemoteFx3dVideoAdapter";
                }
                else if (c == 358)
                {
                    textBox1.Text = "Get-VMRemoteFXPhysicalVideoAdapter";
                }
                else if (c == 359)
                {
                    textBox1.Text = "Get-VMReplication";
                }
                else if (c == 360)
                {
                    textBox1.Text = "Get-VMReplicationAuthorizationEntry";
                }
                else if (c == 361)
                {
                    textBox1.Text = "Get-VMReplicationServer";
                }
                else if (c == 362)
                {
                    textBox1.Text = "Get-VMResourcePool";
                }
                else if (c == 363)
                {
                    textBox1.Text = "Get-VMSan";
                }
                else if (c == 364)
                {
                    textBox1.Text = "Get-VMScsiController";
                }
                else if (c == 365)
                {
                    textBox1.Text = "Get-VMSecurity";
                }
                else if (c == 366)
                {
                    textBox1.Text = "Get-VMSnapshot";
                }
                else if (c == 367)
                {
                    textBox1.Text = "Get-VMStoragePath";
                }
                else if (c == 368)
                {
                    textBox1.Text = "Get-VMStorageSettings";
                }
                else if (c == 369)
                {
                    textBox1.Text = "Get-VMSwitch";
                }
                else if (c == 370)
                {
                    textBox1.Text = "Get-VMSwitchExtension";
                }
                else if (c == 371)
                {
                    textBox1.Text = "Get-VMSwitchExtensionPortData";
                }
                else if (c == 372)
                {
                    textBox1.Text = "Get-VMSwitchExtensionPortFeature";
                }
                else if (c == 373)
                {
                    textBox1.Text = "Get-VMSwitchExtensionSwitchData";
                }
                else if (c == 374)
                {
                    textBox1.Text = "Get-VMSwitchExtensionSwitchFeature";
                }
                else if (c == 375)
                {
                    textBox1.Text = "Get-VMSwitchTeam";
                }
                else if (c == 376)
                {
                    textBox1.Text = "Get-VMSystemSwitchExtension";
                }
                else if (c == 377)
                {
                    textBox1.Text = "Get-VMSystemSwitchExtensionPortFeature";
                }
                else if (c == 378)
                {
                    textBox1.Text = "Get-VMSystemSwitchExtensionSwitchFeature";
                }
                else if (c == 379)
                {
                    textBox1.Text = "Get-VMVideo";
                }
                else if (c == 380)
                {
                    textBox1.Text = "Get-WheaMemoryPolicy";
                }
                else if (c == 381)
                {
                    textBox1.Text = "Get-WIMBootEntry";
                }
                else if (c == 382)
                {
                    textBox1.Text = "Get-WinAcceptLanguageFromLanguageListOptOut";
                }
                else if (c == 383)
                {
                    textBox1.Text = "Get-WinCultureFromLanguageListOptOut";
                }
                else if (c == 384)
                {
                    textBox1.Text = "Get-WinDefaultInputMethodOverride";
                }
                else if (c == 385)
                {
                    textBox1.Text = "Get-WindowsCapability";
                }
                else if (c == 386)
                {
                    textBox1.Text = "Get-WindowsDeveloperLicense";
                }
                else if (c == 387)
                {
                    textBox1.Text = "Get-WindowsDriver";
                }
                else if (c == 388)
                {
                    textBox1.Text = "Get-WindowsEdition";
                }
                else if (c == 389)
                {
                    textBox1.Text = "Get-WindowsErrorReporting";
                }
                else if (c == 390)
                {
                    textBox1.Text = "Get-WindowsImage";
                }
                else if (c == 391)
                {
                    textBox1.Text = "Get-WindowsImageContent";
                }
                else if (c == 392)
                {
                    textBox1.Text = "Get-WindowsOptionalFeature";
                }
                else if (c == 393)
                {
                    textBox1.Text = "Get-WindowsPackage";
                }
                else if (c == 394)
                {
                    textBox1.Text = "Get-WindowsReservedStorageState";
                }
                else if (c == 395)
                {
                    textBox1.Text = "Get-WindowsSearchSetting";
                }
                else if (c == 396)
                {
                    textBox1.Text = "Get-WinEvent";
                }
                else if (c == 397)
                {
                    textBox1.Text = "Get-WinHomeLocation";
                }
                else if (c == 398)
                {
                    textBox1.Text = "Get-WinLanguageBarOption";
                }
                else if (c == 399)
                {
                    textBox1.Text = "Get-WinSystemLocale";
                }
                else if (c == 400)
                {
                    textBox1.Text = "Get-WinUILanguageOverride";
                }
                else if (c == 401)
                {
                    textBox1.Text = "Get-WinUserLanguageList";
                }
                else if (c == 402)
                {
                    textBox1.Text = "Get-WmiObject";
                }
                else if (c == 403)
                {
                    textBox1.Text = "Get-WSManCredSSP";
                }
                else if (c == 404)
                {
                    textBox1.Text = "Get-WSManInstance";
                }
                else if (c == 405)
                {
                    textBox1.Text = "Grant-VMConnectAccess";
                }
                else if (c == 406)
                {
                    textBox1.Text = "Group-Object";
                }
                else if (c == 407)
                {
                    textBox1.Text = "Import-Alias";
                }
                else if (c == 408)
                {
                    textBox1.Text = "Import-BinaryMiLog";
                }
                else if (c == 409)
                {
                    textBox1.Text = "Import-Certificate";
                }
                else if (c == 410)
                {
                    textBox1.Text = "Import-Clixml";
                }
                else if (c == 411)
                {
                    textBox1.Text = "Import-Counter";
                }
                else if (c == 412)
                {
                    textBox1.Text = "Import-Csv";
                }
                else if (c == 413)
                {
                    textBox1.Text = "Import-LocalizedData";
                }
                else if (c == 414)
                {
                    textBox1.Text = "Import-Module";
                }
                else if (c == 415)
                {
                    textBox1.Text = "Import-PackageProvider";
                }
                else if (c == 416)
                {
                    textBox1.Text = "Import-PfxCertificate";
                }
                else if (c == 417)
                {
                    textBox1.Text = "Import-PSSession";
                }
                else if (c == 418)
                {
                    textBox1.Text = "Import-StartLayout";
                }
                else if (c == 419)
                {
                    textBox1.Text = "Import-TpmOwnerAuth";
                }
                else if (c == 420)
                {
                    textBox1.Text = "Import-UevConfiguration";
                }
                else if (c == 421)
                {
                    textBox1.Text = "Import-VM";
                }
                else if (c == 422)
                {
                    textBox1.Text = "Import-VMInitialReplication";
                }
                else if (c == 423)
                {
                    textBox1.Text = "Initialize-PmemPhysicalDevice";
                }
                else if (c == 424)
                {
                    textBox1.Text = "Initialize-Tpm";
                }
                else if (c == 425)
                {
                    textBox1.Text = "Install-Package";
                }
                else if (c == 426)
                {
                    textBox1.Text = "Install-PackageProvider";
                }
                else if (c == 427)
                {
                    textBox1.Text = "Install-ProvisioningPackage";
                }
                else if (c == 428)
                {
                    textBox1.Text = "Install-TrustedProvisioningCertificate";
                }
                else if (c == 429)
                {
                    textBox1.Text = "Invoke-CimMethod";
                }
                else if (c == 430)
                {
                    textBox1.Text = "Invoke-Command";
                }
                else if (c == 431)
                {
                    textBox1.Text = "Invoke-CommandInDesktopPackage";
                }
                else if (c == 432)
                {
                    textBox1.Text = "Invoke-DscResource";
                }
                else if (c == 433)
                {
                    textBox1.Text = "Invoke-Expression";
                }
                else if (c == 434)
                {
                    textBox1.Text = "Invoke-History";
                }
                else if (c == 435)
                {
                    textBox1.Text = "Invoke-Item";
                }
                else if (c == 436)
                {
                    textBox1.Text = "Invoke-RestMethod";
                }
                else if (c == 437)
                {
                    textBox1.Text = "Invoke-TroubleshootingPack";
                }
                else if (c == 438)
                {
                    textBox1.Text = "Invoke-WebRequest";
                }
                else if (c == 439)
                {
                    textBox1.Text = "Invoke-WmiMethod";
                }
                else if (c == 440)
                {
                    textBox1.Text = "Invoke-WSManAction";
                }
                else if (c == 441)
                {
                    textBox1.Text = "Join-DtcDiagnosticResourceManager";
                }
                else if (c == 442)
                {
                    textBox1.Text = "Join-Path";
                }
                else if (c == 443)
                {
                    textBox1.Text = "Limit-EventLog";
                }
                else if (c == 444)
                {
                    textBox1.Text = "Measure-Command";
                }
                else if (c == 445)
                {
                    textBox1.Text = "Measure-Object";
                }
                else if (c == 446)
                {
                    textBox1.Text = "Measure-VM";
                }
                else if (c == 447)
                {
                    textBox1.Text = "Measure-VMReplication";
                }
                else if (c == 448)
                {
                    textBox1.Text = "Measure-VMResourcePool";
                }
                else if (c == 449)
                {
                    textBox1.Text = "Merge-CIPolicy";
                }
                else if (c == 450)
                {
                    textBox1.Text = "Merge-VHD";
                }
                else if (c == 451)
                {
                    textBox1.Text = "Mount-AppvClientConnectionGroup";
                }
                else if (c == 452)
                {
                    textBox1.Text = "Mount-AppvClientPackage";
                }
                else if (c == 453)
                {
                    textBox1.Text = "Mount-AppxVolume";
                }
                else if (c == 454)
                {
                    textBox1.Text = "Mount-VHD";
                }
                else if (c == 455)
                {
                    textBox1.Text = "Mount-VMHostAssignableDevice";
                }
                else if (c == 456)
                {
                    textBox1.Text = "Mount-WindowsImage";
                }
                else if (c == 457)
                {
                    textBox1.Text = "Move-AppxPackage";
                }
                else if (c == 458)
                {
                    textBox1.Text = "Move-Item";
                }
                else if (c == 459)
                {
                    textBox1.Text = "Move-ItemProperty";
                }
                else if (c == 460)
                {
                    textBox1.Text = "Move-VM";
                }
                else if (c == 461)
                {
                    textBox1.Text = "Move-VMStorage";
                }
                else if (c == 462)
                {
                    textBox1.Text = "New-Alias";
                }
                else if (c == 463)
                {
                    textBox1.Text = "New-AppLockerPolicy";
                }
                else if (c == 464)
                {
                    textBox1.Text = "New-CertificateNotificationTask";
                }
                else if (c == 465)
                {
                    textBox1.Text = "New-CimInstance";
                }
                else if (c == 466)
                {
                    textBox1.Text = "New-CimSession";
                }
                else if (c == 467)
                {
                    textBox1.Text = "New-CimSessionOption";
                }
                else if (c == 468)
                {
                    textBox1.Text = "New-CIPolicy";
                }
                else if (c == 469)
                {
                    textBox1.Text = "New-CIPolicyRule";
                }
                else if (c == 470)
                {
                    textBox1.Text = "New-DtcDiagnosticTransaction";
                }
                else if (c == 471)
                {
                    textBox1.Text = "New-Event";
                }
                else if (c == 472)
                {
                    textBox1.Text = "New-EventLog";
                }
                else if (c == 473)
                {
                    textBox1.Text = "New-FileCatalog";
                }
                else if (c == 474)
                {
                    textBox1.Text = "New-HgsTraceTarget";
                }
                else if (c == 475)
                {
                    textBox1.Text = "New-Item";
                }
                else if (c == 476)
                {
                    textBox1.Text = "New-ItemProperty";
                }
                else if (c == 477)
                {
                    textBox1.Text = "New-JobTrigger";
                }
                else if (c == 478)
                {
                    textBox1.Text = "New-LocalGroup";
                }
                else if (c == 479)
                {
                    textBox1.Text = "New-LocalUser";
                }
                else if (c == 480)
                {
                    textBox1.Text = "New-Module";
                }
                else if (c == 481)
                {
                    textBox1.Text = "New-ModuleManifest";
                }
                else if (c == 482)
                {
                    textBox1.Text = "New-NetIPsecAuthProposal";
                }
                else if (c == 483)
                {
                    textBox1.Text = "New-NetIPsecMainModeCryptoProposal";
                }
                else if (c == 484)
                {
                    textBox1.Text = "New-NetIPsecQuickModeCryptoProposal";
                }
                else if (c == 485)
                {
                    textBox1.Text = "New-Object";
                }
                else if (c == 486)
                {
                    textBox1.Text = "New-PmemDisk";
                }
                else if (c == 487)
                {
                    textBox1.Text = "New-ProvisioningRepro";
                }
                else if (c == 488)
                {
                    textBox1.Text = "New-PSDrive";
                }
                else if (c == 489)
                {
                    textBox1.Text = "New-PSRoleCapabilityFile";
                }
                else if (c == 490)
                {
                    textBox1.Text = "New-PSSession";
                }
                else if (c == 491)
                {
                    textBox1.Text = "New-PSSessionConfigurationFile";
                }
                else if (c == 492)
                {
                    textBox1.Text = "New-PSSessionOption";
                }
                else if (c == 493)
                {
                    textBox1.Text = "New-PSTransportOption";
                }
                else if (c == 494)
                {
                    textBox1.Text = "New-PSWorkflowExecutionOption";
                }
                else if (c == 495)
                {
                    textBox1.Text = "New-ScheduledJobOption";
                }
                else if (c == 496)
                {
                    textBox1.Text = "New-SelfSignedCertificate";
                }
                else if (c == 497)
                {
                    textBox1.Text = "New-Service";
                }
                else if (c == 498)
                {
                    textBox1.Text = "New-TimeSpan";
                }
                else if (c == 499)
                {
                    textBox1.Text = "New-TlsSessionTicketKey";
                }
                else if (c == 500)
                {
                    textBox1.Text = "New-Variable";
                }
                else if (c == 501)
                {
                    textBox1.Text = "New-VFD";
                }
                else if (c == 502)
                {
                    textBox1.Text = "New-VHD";
                }
                else if (c == 503)
                {
                    textBox1.Text = "New-VM";
                }
                else if (c == 504)
                {
                    textBox1.Text = "New-VMGroup";
                }
                else if (c == 505)
                {
                    textBox1.Text = "New-VMReplicationAuthorizationEntry";
                }
                else if (c == 506)
                {
                    textBox1.Text = "New-VMResourcePool";
                }
                else if (c == 507)
                {
                    textBox1.Text = "New-VMSan";
                }
                else if (c == 508)
                {
                    textBox1.Text = "New-VMSwitch";
                }
                else if (c == 509)
                {
                    textBox1.Text = "New-WebServiceProxy";
                }
                else if (c == 510)
                {
                    textBox1.Text = "New-WindowsCustomImage";
                }
                else if (c == 511)
                {
                    textBox1.Text = "New-WindowsImage";
                }
                else if (c == 512)
                {
                    textBox1.Text = "New-WinEvent";
                }
                else if (c == 513)
                {
                    textBox1.Text = "New-WinUserLanguageList";
                }
                else if (c == 514)
                {
                    textBox1.Text = "New-WSManInstance";
                }
                else if (c == 515)
                {
                    textBox1.Text = "New-WSManSessionOption";
                }
                else if (c == 516)
                {
                    textBox1.Text = "Optimize-AppXProvisionedPackages";
                }
                else if (c == 517)
                {
                    textBox1.Text = "Optimize-VHD";
                }
                else if (c == 518)
                {
                    textBox1.Text = "Optimize-VHDSet";
                }
                else if (c == 519)
                {
                    textBox1.Text = "Optimize-WindowsImage";
                }
                else if (c == 520)
                {
                    textBox1.Text = "Out-Default";
                }
                else if (c == 521)
                {
                    textBox1.Text = "Out-File";
                }
                else if (c == 522)
                {
                    textBox1.Text = "Out-GridView";
                }
                else if (c == 523)
                {
                    textBox1.Text = "Out-Host";
                }
                else if (c == 524)
                {
                    textBox1.Text = "Out-Null";
                }
                else if (c == 525)
                {
                    textBox1.Text = "Out-Printer";
                }
                else if (c == 526)
                {
                    textBox1.Text = "Out-String";
                }
                else if (c == 527)
                {
                    textBox1.Text = "Pop-Location";
                }
                else if (c == 528)
                {
                    textBox1.Text = "Protect-CmsMessage";
                }
                else if (c == 529)
                {
                    textBox1.Text = "Publish-AppvClientPackage";
                }
                else if (c == 530)
                {
                    textBox1.Text = "Publish-DscConfiguration";
                }
                else if (c == 531)
                {
                    textBox1.Text = "Push-Location";
                }
                else if (c == 532)
                {
                    textBox1.Text = "Read-Host";
                }
                else if (c == 533)
                {
                    textBox1.Text = "Receive-DtcDiagnosticTransaction";
                }
                else if (c == 534)
                {
                    textBox1.Text = "Receive-Job";
                }
                else if (c == 535)
                {
                    textBox1.Text = "Receive-PSSession";
                }
                else if (c == 536)
                {
                    textBox1.Text = "Register-ArgumentCompleter";
                }
                else if (c == 537)
                {
                    textBox1.Text = "Register-CimIndicationEvent";
                }
                else if (c == 538)
                {
                    textBox1.Text = "Register-EngineEvent";
                }
                else if (c == 539)
                {
                    textBox1.Text = "Register-ObjectEvent";
                }
                else if (c == 540)
                {
                    textBox1.Text = "Register-PackageSource";
                }
                else if (c == 541)
                {
                    textBox1.Text = "Register-PSSessionConfiguration";
                }
                else if (c == 542)
                {
                    textBox1.Text = "Register-ScheduledJob";
                }
                else if (c == 543)
                {
                    textBox1.Text = "Register-UevTemplate";
                }
                else if (c == 544)
                {
                    textBox1.Text = "Register-WmiEvent";
                }
                else if (c == 545)
                {
                    textBox1.Text = "Remove-AppvClientConnectionGroup";
                }
                else if (c == 546)
                {
                    textBox1.Text = "Remove-AppvClientPackage";
                }
                else if (c == 547)
                {
                    textBox1.Text = "Remove-AppvPublishingServer";
                }
                else if (c == 548)
                {
                    textBox1.Text = "Remove-AppxPackage";
                }
                else if (c == 549)
                {
                    textBox1.Text = "Remove-AppxProvisionedPackage";
                }
                else if (c == 550)
                {
                    textBox1.Text = "Remove-AppxVolume";
                }
                else if (c == 551)
                {
                    textBox1.Text = "Remove-BitsTransfer";
                }
                else if (c == 552)
                {
                    textBox1.Text = "Remove-CertificateEnrollmentPolicyServer";
                }
                else if (c == 553)
                {
                    textBox1.Text = "Remove-CertificateNotificationTask";
                }
                else if (c == 554)
                {
                    textBox1.Text = "Remove-CimInstance";
                }
                else if (c == 555)
                {
                    textBox1.Text = "Remove-CimSession";
                }
                else if (c == 556)
                {
                    textBox1.Text = "Remove-CIPolicyRule";
                }
                else if (c == 557)
                {
                    textBox1.Text = "Remove-Computer";
                }
                else if (c == 558)
                {
                    textBox1.Text = "Remove-Event";
                }
                else if (c == 559)
                {
                    textBox1.Text = "Remove-EventLog";
                }
                else if (c == 560)
                {
                    textBox1.Text = "Remove-Item";
                }
                else if (c == 561)
                {
                    textBox1.Text = "Remove-ItemProperty";
                }
                else if (c == 562)
                {
                    textBox1.Text = "Remove-Job";
                }
                else if (c == 563)
                {
                    textBox1.Text = "Remove-JobTrigger";
                }
                else if (c == 564)
                {
                    textBox1.Text = "Remove-LocalGroup";
                }
                else if (c == 565)
                {
                    textBox1.Text = "Remove-LocalGroupMember";
                }
                else if (c == 566)
                {
                    textBox1.Text = "Remove-LocalUser";
                }
                else if (c == 567)
                {
                    textBox1.Text = "Remove-Module";
                }
                else if (c == 568)
                {
                    textBox1.Text = "Remove-PmemDisk";
                }
                else if (c == 569)
                {
                    textBox1.Text = "Remove-PSBreakpoint";
                }
                else if (c == 570)
                {
                    textBox1.Text = "Remove-PSDrive";
                }
                else if (c == 571)
                {
                    textBox1.Text = "Remove-PSReadLineKeyHandler";
                }
                else if (c == 572)
                {
                    textBox1.Text = "Remove-PSSession";
                }
                else if (c == 573)
                {
                    textBox1.Text = "Remove-PSSnapin";
                }
                else if (c == 574)
                {
                    textBox1.Text = "Remove-TypeData";
                }
                else if (c == 575)
                {
                    textBox1.Text = "Remove-Variable";
                }
                else if (c == 576)
                {
                    textBox1.Text = "Remove-VHDSnapshot";
                }
                else if (c == 577)
                {
                    textBox1.Text = "Remove-VM";
                }
                else if (c == 578)
                {
                    textBox1.Text = "Remove-VMAssignableDevice";
                }
                else if (c == 579)
                {
                    textBox1.Text = "Remove-VMDvdDrive";
                }
                else if (c == 580)
                {
                    textBox1.Text = "Remove-VMFibreChannelHba";
                }
                else if (c == 581)
                {
                    textBox1.Text = "Remove-VMGpuPartitionAdapter";
                }
                else if (c == 582)
                {
                    textBox1.Text = "Remove-VMGroup";
                }
                else if (c == 583)
                {
                    textBox1.Text = "Remove-VMGroupMember";
                }
                else if (c == 584)
                {
                    textBox1.Text = "Remove-VMHardDiskDrive";
                }
                else if (c == 585)
                {
                    textBox1.Text = "Remove-VMHostAssignableDevice";
                }
                else if (c == 586)
                {
                    textBox1.Text = "Remove-VMKeyStorageDrive";
                }
                else if (c == 587)
                {
                    textBox1.Text = "Remove-VMMigrationNetwork";
                }
                else if (c == 588)
                {
                    textBox1.Text = "Remove-VMNetworkAdapter";
                }
                else if (c == 589)
                {
                    textBox1.Text = "Remove-VMNetworkAdapterAcl";
                }
                else if (c == 590)
                {
                    textBox1.Text = "Remove-VMNetworkAdapterExtendedAcl";
                }
                else if (c == 591)
                {
                    textBox1.Text = "Remove-VMNetworkAdapterRoutingDomainMapping";
                }
                else if (c == 592)
                {
                    textBox1.Text = "Remove-VMNetworkAdapterTeamMapping";
                }
                else if (c == 593)
                {
                    textBox1.Text = "Remove-VMPmemController";
                }
                else if (c == 594)
                {
                    textBox1.Text = "Remove-VMRemoteFx3dVideoAdapter";
                }
                else if (c == 595)
                {
                    textBox1.Text = "Remove-VMReplication";
                }
                else if (c == 596)
                {
                    textBox1.Text = "Remove-VMReplicationAuthorizationEntry";
                }
                else if (c == 597)
                {
                    textBox1.Text = "Remove-VMResourcePool";
                }
                else if (c == 598)
                {
                    textBox1.Text = "Remove-VMSan";
                }
                else if (c == 599)
                {
                    textBox1.Text = "Remove-VMSavedState";
                }
                else if (c == 600)
                {
                    textBox1.Text = "Remove-VMScsiController";
                }
                else if (c == 601)
                {
                    textBox1.Text = "Remove-VMSnapshot";
                }
                else if (c == 602)
                {
                    textBox1.Text = "Remove-VMStoragePath";
                }
                else if (c == 603)
                {
                    textBox1.Text = "Remove-VMSwitch";
                }
                else if (c == 604)
                {
                    textBox1.Text = "Remove-VMSwitchExtensionPortFeature";
                }
                else if (c == 605)
                {
                    textBox1.Text = "Remove-VMSwitchExtensionSwitchFeature";
                }
                else if (c == 606)
                {
                    textBox1.Text = "Remove-VMSwitchTeamMember";
                }
                else if (c == 607)
                {
                    textBox1.Text = "Remove-WindowsCapability";
                }
                else if (c == 608)
                {
                    textBox1.Text = "Remove-WindowsDriver";
                }
                else if (c == 609)
                {
                    textBox1.Text = "Remove-WindowsImage";
                }
                else if (c == 610)
                {
                    textBox1.Text = "Remove-WindowsPackage";
                }
                else if (c == 611)
                {
                    textBox1.Text = "Remove-WmiObject";
                }
                else if (c == 612)
                {
                    textBox1.Text = "Remove-WSManInstance";
                }
                else if (c == 613)
                {
                    textBox1.Text = "Rename-Computer";
                }
                else if (c == 614)
                {
                    textBox1.Text = "Rename-Item";
                }
                else if (c == 615)
                {
                    textBox1.Text = "Rename-ItemProperty";
                }
                else if (c == 616)
                {
                    textBox1.Text = "Rename-LocalGroup";
                }
                else if (c == 617)
                {
                    textBox1.Text = "Rename-LocalUser";
                }
                else if (c == 618)
                {
                    textBox1.Text = "Rename-VM";
                }
                else if (c == 619)
                {
                    textBox1.Text = "Rename-VMGroup";
                }
                else if (c == 620)
                {
                    textBox1.Text = "Rename-VMNetworkAdapter";
                }
                else if (c == 621)
                {
                    textBox1.Text = "Rename-VMResourcePool";
                }
                else if (c == 622)
                {
                    textBox1.Text = "Rename-VMSan";
                }
                else if (c == 623)
                {
                    textBox1.Text = "Rename-VMSnapshot";
                }
                else if (c == 624)
                {
                    textBox1.Text = "Rename-VMSwitch";
                }
                else if (c == 625)
                {
                    textBox1.Text = "Repair-AppvClientConnectionGroup";
                }
                else if (c == 626)
                {
                    textBox1.Text = "Repair-AppvClientPackage";
                }
                else if (c == 627)
                {
                    textBox1.Text = "Repair-UevTemplateIndex";
                }
                else if (c == 628)
                {
                    textBox1.Text = "Repair-VM";
                }
                else if (c == 629)
                {
                    textBox1.Text = "Repair-WindowsImage";
                }
                else if (c == 630)
                {
                    textBox1.Text = "Reset-ComputerMachinePassword";
                }
                else if (c == 631)
                {
                    textBox1.Text = "Reset-VMReplicationStatistics";
                }
                else if (c == 632)
                {
                    textBox1.Text = "Reset-VMResourceMetering";
                }
                else if (c == 633)
                {
                    textBox1.Text = "Resize-VHD";
                }
                else if (c == 634)
                {
                    textBox1.Text = "Resolve-DnsName";
                }
                else if (c == 635)
                {
                    textBox1.Text = "Resolve-Path";
                }
                else if (c == 636)
                {
                    textBox1.Text = "Restart-Computer";
                }
                else if (c == 637)
                {
                    textBox1.Text = "Restart-Service";
                }
                else if (c == 638)
                {
                    textBox1.Text = "Restart-VM";
                }
                else if (c == 639)
                {
                    textBox1.Text = "Restore-Computer";
                }
                else if (c == 640)
                {
                    textBox1.Text = "Restore-UevBackup";
                }
                else if (c == 641)
                {
                    textBox1.Text = "Restore-UevUserSetting";
                }
                else if (c == 642)
                {
                    textBox1.Text = "Restore-VMSnapshot";
                }
                else if (c == 643)
                {
                    textBox1.Text = "Resume-BitsTransfer";
                }
                else if (c == 644)
                {
                    textBox1.Text = "Resume-Job";
                }
                else if (c == 645)
                {
                    textBox1.Text = "Resume-ProvisioningSession";
                }
                else if (c == 646)
                {
                    textBox1.Text = "Resume-Service";
                }
                else if (c == 647)
                {
                    textBox1.Text = "Resume-VM";
                }
                else if (c == 648)
                {
                    textBox1.Text = "Resume-VMReplication";
                }
                else if (c == 649)
                {
                    textBox1.Text = "Revoke-VMConnectAccess";
                }
                else if (c == 650)
                {
                    textBox1.Text = "Save-Help";
                }
                else if (c == 651)
                {
                    textBox1.Text = "Save-Package";
                }
                else if (c == 652)
                {
                    textBox1.Text = "Save-VM";
                }
                else if (c == 653)
                {
                    textBox1.Text = "Save-WindowsImage";
                }
                else if (c == 654)
                {
                    textBox1.Text = "Select-Object";
                }
                else if (c == 655)
                {
                    textBox1.Text = "Select-String";
                }
                else if (c == 656)
                {
                    textBox1.Text = "Select-Xml";
                }
                else if (c == 657)
                {
                    textBox1.Text = "Send-AppvClientReport";
                }
                else if (c == 658)
                {
                    textBox1.Text = "Send-DtcDiagnosticTransaction";
                }
                else if (c == 659)
                {
                    textBox1.Text = "Send-MailMessage";
                }
                else if (c == 660)
                {
                    textBox1.Text = "Set-Acl";
                }
                else if (c == 661)
                {
                    textBox1.Text = "Set-Alias";
                }
                else if (c == 662)
                {
                    textBox1.Text = "Set-AppBackgroundTaskResourcePolicy";
                }
                else if (c == 663)
                {
                    textBox1.Text = "Set-AppLockerPolicy";
                }
                else if (c == 664)
                {
                    textBox1.Text = "Set-AppvClientConfiguration";
                }
                else if (c == 665)
                {
                    textBox1.Text = "Set-AppvClientMode";
                }
                else if (c == 666)
                {
                    textBox1.Text = "Set-AppvClientPackage";
                }
                else if (c == 667)
                {
                    textBox1.Text = "Set-AppvPublishingServer";
                }
                else if (c == 668)
                {
                    textBox1.Text = "Set-AppxDefaultVolume";
                }
                else if (c == 669)
                {
                    textBox1.Text = "Set-AppXProvisionedDataFile";
                }
                else if (c == 670)
                {
                    textBox1.Text = "Set-AuthenticodeSignature";
                }
                else if (c == 671)
                {
                    textBox1.Text = "Set-BitsTransfer";
                }
                else if (c == 672)
                {
                    textBox1.Text = "Set-CertificateAutoEnrollmentPolicy";
                }
                else if (c == 673)
                {
                    textBox1.Text = "Set-CimInstance";
                }
                else if (c == 674)
                {
                    textBox1.Text = "Set-CIPolicyIdInfo";
                }
                else if (c == 675)
                {
                    textBox1.Text = "Set-CIPolicySetting";
                }
                else if (c == 676)
                {
                    textBox1.Text = "Set-CIPolicyVersion";
                }
                else if (c == 677)
                {
                    textBox1.Text = "Set-Clipboard";
                }
                else if (c == 678)
                {
                    textBox1.Text = "Set-Content";
                }
                else if (c == 679)
                {
                    textBox1.Text = "Set-Culture";
                }
                else if (c == 680)
                {
                    textBox1.Text = "Set-Date";
                }
                else if (c == 681)
                {
                    textBox1.Text = "Set-DeliveryOptimizationStatus";
                }
                else if (c == 682)
                {
                    textBox1.Text = "Set-DODownloadMode";
                }
                else if (c == 683)
                {
                    textBox1.Text = "Set-DOPercentageMaxBackgroundBandwidth";
                }
                else if (c == 684)
                {
                    textBox1.Text = "Set-DOPercentageMaxForegroundBandwidth";
                }
                else if (c == 685)
                {
                    textBox1.Text = "Set-DscLocalConfigurationManager";
                }
                else if (c == 686)
                {
                    textBox1.Text = "Set-ExecutionPolicy";
                }
                else if (c == 687)
                {
                    textBox1.Text = "Set-HVCIOptions";
                }
                else if (c == 688)
                {
                    textBox1.Text = "Set-Item";
                }
                else if (c == 689)
                {
                    textBox1.Text = "Set-ItemProperty";
                }
                else if (c == 690)
                {
                    textBox1.Text = "Set-JobTrigger";
                }
                else if (c == 691)
                {
                    textBox1.Text = "Set-KdsConfiguration";
                }
                else if (c == 692)
                {
                    textBox1.Text = "Set-LocalGroup";
                }
                else if (c == 693)
                {
                    textBox1.Text = "Set-LocalUser";
                }
                else if (c == 694)
                {
                    textBox1.Text = "Set-Location";
                }
                else if (c == 695)
                {
                    textBox1.Text = "Set-NonRemovableAppsPolicy";
                }
                else if (c == 696)
                {
                    textBox1.Text = "Set-PackageSource";
                }
                else if (c == 697)
                {
                    textBox1.Text = "Set-ProcessMitigation";
                }
                else if (c == 698)
                {
                    textBox1.Text = "Set-PSBreakpoint";
                }
                else if (c == 699)
                {
                    textBox1.Text = "Set-PSDebug";
                }
                else if (c == 700)
                {
                    textBox1.Text = "Set-PSReadLineKeyHandler";
                }
                else if (c == 701)
                {
                    textBox1.Text = "Set-PSReadLineOption";
                }
                else if (c == 702)
                {
                    textBox1.Text = "Set-PSSessionConfiguration";
                }
                else if (c == 703)
                {
                    textBox1.Text = "Set-RuleOption";
                }
                else if (c == 704)
                {
                    textBox1.Text = "Set-ScheduledJob";
                }
                else if (c == 705)
                {
                    textBox1.Text = "Set-ScheduledJobOption";
                }
                else if (c == 706)
                {
                    textBox1.Text = "Set-SecureBootUEFI";
                }
                else if (c == 707)
                {
                    textBox1.Text = "Set-Service";
                }
                else if (c == 708)
                {
                    textBox1.Text = "Set-StrictMode";
                }
                else if (c == 709)
                {
                    textBox1.Text = "Set-TimeZone";
                }
                else if (c == 710)
                {
                    textBox1.Text = "Set-TpmOwnerAuth";
                }
                else if (c == 711)
                {
                    textBox1.Text = "Set-TraceSource";
                }
                else if (c == 712)
                {
                    textBox1.Text = "Set-UevConfiguration";
                }
                else if (c == 713)
                {
                    textBox1.Text = "Set-UevTemplateProfile";
                }
                else if (c == 714)
                {
                    textBox1.Text = "Set-Variable";
                }
                else if (c == 715)
                {
                    textBox1.Text = "Set-VHD";
                }
                else if (c == 716)
                {
                    textBox1.Text = "Set-VM";
                }
                else if (c == 717)
                {
                    textBox1.Text = "Set-VMBios";
                }
                else if (c == 718)
                {
                    textBox1.Text = "Set-VMComPort";
                }
                else if (c == 719)
                {
                    textBox1.Text = "Set-VMDvdDrive";
                }
                else if (c == 720)
                {
                    textBox1.Text = "Set-VMFibreChannelHba";
                }
                else if (c == 721)
                {
                    textBox1.Text = "Set-VMFirmware";
                }
                else if (c == 722)
                {
                    textBox1.Text = "Set-VMFloppyDiskDrive";
                }
                else if (c == 723)
                {
                    textBox1.Text = "Set-VMGpuPartitionAdapter";
                }
                else if (c == 724)
                {
                    textBox1.Text = "Set-VMHardDiskDrive";
                }
                else if (c == 725)
                {
                    textBox1.Text = "Set-VMHost";
                }
                else if (c == 726)
                {
                    textBox1.Text = "Set-VMHostCluster";
                }
                else if (c == 727)
                {
                    textBox1.Text = "Set-VMKeyProtector";
                }
                else if (c == 728)
                {
                    textBox1.Text = "Set-VMKeyStorageDrive";
                }
                else if (c == 729)
                {
                    textBox1.Text = "Set-VMMemory";
                }
                else if (c == 730)
                {
                    textBox1.Text = "Set-VMMigrationNetwork";
                }
                else if (c == 731)
                {
                    textBox1.Text = "Set-VMNetworkAdapter";
                }
                else if (c == 732)
                {
                    textBox1.Text = "Set-VMNetworkAdapterFailoverConfiguration";
                }
                else if (c == 733)
                {
                    textBox1.Text = "Set-VMNetworkAdapterIsolation";
                }
                else if (c == 734)
                {
                    textBox1.Text = "Set-VMNetworkAdapterRdma";
                }
                else if (c == 735)
                {
                    textBox1.Text = "Set-VMNetworkAdapterRoutingDomainMapping";
                }
                else if (c == 736)
                {
                    textBox1.Text = "Set-VMNetworkAdapterTeamMapping";
                }
                else if (c == 737)
                {
                    textBox1.Text = "Set-VMNetworkAdapterVlan";
                }
                else if (c == 738)
                {
                    textBox1.Text = "Set-VMPartitionableGpu";
                }
                else if (c == 739)
                {
                    textBox1.Text = "Set-VMProcessor";
                }
                else if (c == 740)
                {
                    textBox1.Text = "Set-VMRemoteFx3dVideoAdapter";
                }
                else if (c == 741)
                {
                    textBox1.Text = "Set-VMReplication";
                }
                else if (c == 742)
                {
                    textBox1.Text = "Set-VMReplicationAuthorizationEntry";
                }
                else if (c == 743)
                {
                    textBox1.Text = "Set-VMReplicationServer";
                }
                else if (c == 744)
                {
                    textBox1.Text = "Set-VMResourcePool";
                }
                else if (c == 745)
                {
                    textBox1.Text = "Set-VMSan";
                }
                else if (c == 746)
                {
                    textBox1.Text = "Set-VMSecurity";
                }
                else if (c == 747)
                {
                    textBox1.Text = "Set-VMSecurityPolicy";
                }
                else if (c == 748)
                {
                    textBox1.Text = "Set-VMStorageSettings";
                }
                else if (c == 749)
                {
                    textBox1.Text = "Set-VMSwitch";
                }
                else if (c == 750)
                {
                    textBox1.Text = "Set-VMSwitchExtensionPortFeature";
                }
                else if (c == 751)
                {
                    textBox1.Text = "Set-VMSwitchExtensionSwitchFeature";
                }
                else if (c == 752)
                {
                    textBox1.Text = "Set-VMSwitchTeam";
                }
                else if (c == 753)
                {
                    textBox1.Text = "Set-VMVideo";
                }
                else if (c == 754)
                {
                    textBox1.Text = "Set-WheaMemoryPolicy";
                }
                else if (c == 755)
                {
                    textBox1.Text = "Set-WinAcceptLanguageFromLanguageListOptOut";
                }
                else if (c == 756)
                {
                    textBox1.Text = "Set-WinCultureFromLanguageListOptOut";
                }
                else if (c == 757)
                {
                    textBox1.Text = "Set-WinDefaultInputMethodOverride";
                }
                else if (c == 758)
                {
                    textBox1.Text = "Set-WindowsEdition";
                }
                else if (c == 759)
                {
                    textBox1.Text = "Set-WindowsProductKey";
                }
                else if (c == 760)
                {
                    textBox1.Text = "Set-WindowsReservedStorageState";
                }
                else if (c == 761)
                {
                    textBox1.Text = "Set-WindowsSearchSetting";
                }
                else if (c == 762)
                {
                    textBox1.Text = "Set-WinHomeLocation";
                }
                else if (c == 763)
                {
                    textBox1.Text = "Set-WinLanguageBarOption";
                }
                else if (c == 764)
                {
                    textBox1.Text = "Set-WinSystemLocale";
                }
                else if (c == 765)
                {
                    textBox1.Text = "Set-WinUILanguageOverride";
                }
                else if (c == 766)
                {
                    textBox1.Text = "Set-WinUserLanguageList";
                }
                else if (c == 767)
                {
                    textBox1.Text = "Set-WmiInstance";
                }
                else if (c == 768)
                {
                    textBox1.Text = "Set-WSManInstance";
                }
                else if (c == 769)
                {
                    textBox1.Text = "Set-WSManQuickConfig";
                }
                else if (c == 770)
                {
                    textBox1.Text = "Show-Command";
                }
                else if (c == 771)
                {
                    textBox1.Text = "Show-ControlPanelItem";
                }
                else if (c == 772)
                {
                    textBox1.Text = "Show-EventLog";
                }
                else if (c == 773)
                {
                    textBox1.Text = "Show-WindowsDeveloperLicenseRegistration";
                }
                else if (c == 774)
                {
                    textBox1.Text = "Sort-Object";
                }
                else if (c == 775)
                {
                    textBox1.Text = "Split-Path";
                }
                else if (c == 776)
                {
                    textBox1.Text = "Split-WindowsImage";
                }
                else if (c == 777)
                {
                    textBox1.Text = "Start-BitsTransfer";
                }
                else if (c == 778)
                {
                    textBox1.Text = "Start-DscConfiguration";
                }
                else if (c == 779)
                {
                    textBox1.Text = "Start-DtcDiagnosticResourceManager";
                }
                else if (c == 780)
                {
                    textBox1.Text = "Start-Job";
                }
                else if (c == 781)
                {
                    textBox1.Text = "Start-OSUninstall";
                }
                else if (c == 782)
                {
                    textBox1.Text = "Start-Process";
                }
                else if (c == 783)
                {
                    textBox1.Text = "Start-Service";
                }
                else if (c == 784)
                {
                    textBox1.Text = "Start-Sleep";
                }
                else if (c == 785)
                {
                    textBox1.Text = "Start-Transaction";
                }
                else if (c == 786)
                {
                    textBox1.Text = "Start-Transcript";
                }
                else if (c == 787)
                {
                    textBox1.Text = "Start-VM";
                }
                else if (c == 788)
                {
                    textBox1.Text = "Start-VMFailover";
                }
                else if (c == 789)
                {
                    textBox1.Text = "Start-VMInitialReplication";
                }
                else if (c == 790)
                {
                    textBox1.Text = "Start-VMTrace";
                }
                else if (c == 791)
                {
                    textBox1.Text = "Stop-AppvClientConnectionGroup";
                }
                else if (c == 792)
                {
                    textBox1.Text = "Stop-AppvClientPackage";
                }
                else if (c == 793)
                {
                    textBox1.Text = "Stop-Computer";
                }
                else if (c == 794)
                {
                    textBox1.Text = "Stop-DtcDiagnosticResourceManager";
                }
                else if (c == 795)
                {
                    textBox1.Text = "Stop-Job";
                }
                else if (c == 796)
                {
                    textBox1.Text = "Stop-Process";
                }
                else if (c == 797)
                {
                    textBox1.Text = "Stop-Service";
                }
                else if (c == 798)
                {
                    textBox1.Text = "Stop-Transcript";
                }
                else if (c == 799)
                {
                    textBox1.Text = "Stop-VM";
                }
                else if (c == 800)
                {
                    textBox1.Text = "Stop-VMFailover";
                }
                else if (c == 801)
                {
                    textBox1.Text = "Stop-VMInitialReplication";
                }
                else if (c == 802)
                {
                    textBox1.Text = "Stop-VMReplication";
                }
                else if (c == 803)
                {
                    textBox1.Text = "Stop-VMTrace";
                }
                else if (c == 804)
                {
                    textBox1.Text = "Suspend-BitsTransfer";
                }
                else if (c == 805)
                {
                    textBox1.Text = "Suspend-Job";
                }
                else if (c == 806)
                {
                    textBox1.Text = "Suspend-Service";
                }
                else if (c == 807)
                {
                    textBox1.Text = "Suspend-VM";
                }
                else if (c == 808)
                {
                    textBox1.Text = "Suspend-VMReplication";
                }
                else if (c == 809)
                {
                    textBox1.Text = "Switch-Certificate";
                }
                else if (c == 810)
                {
                    textBox1.Text = "Sync-AppvPublishingServer";
                }
                else if (c == 811)
                {
                    textBox1.Text = "Tee-Object";
                }
                else if (c == 812)
                {
                    textBox1.Text = "Test-AppLockerPolicy";
                }
                else if (c == 813)
                {
                    textBox1.Text = "Test-Certificate";
                }
                else if (c == 814)
                {
                    textBox1.Text = "Test-ComputerSecureChannel";
                }
                else if (c == 815)
                {
                    textBox1.Text = "Test-Connection";
                }
                else if (c == 816)
                {
                    textBox1.Text = "Test-DscConfiguration";
                }
                else if (c == 817)
                {
                    textBox1.Text = "Test-FileCatalog";
                }
                else if (c == 818)
                {
                    textBox1.Text = "Test-HgsTraceTarget";
                }
                else if (c == 819)
                {
                    textBox1.Text = "Test-KdsRootKey";
                }
                else if (c == 820)
                {
                    textBox1.Text = "Test-ModuleManifest";
                }
                else if (c == 821)
                {
                    textBox1.Text = "Test-Path";
                }
                else if (c == 822)
                {
                    textBox1.Text = "Test-PSSessionConfigurationFile";
                }
                else if (c == 823)
                {
                    textBox1.Text = "Test-UevTemplate";
                }
                else if (c == 824)
                {
                    textBox1.Text = "Test-VHD";
                }
                else if (c == 825)
                {
                    textBox1.Text = "Test-VMNetworkAdapter";
                }
                else if (c == 826)
                {
                    textBox1.Text = "Test-VMReplicationConnection";
                }
                else if (c == 827)
                {
                    textBox1.Text = "Test-WSMan";
                }
                else if (c == 828)
                {
                    textBox1.Text = "Trace-Command";
                }
                else if (c == 829)
                {
                    textBox1.Text = "Unblock-File";
                }
                else if (c == 830)
                {
                    textBox1.Text = "Unblock-Tpm";
                }
                else if (c == 831)
                {
                    textBox1.Text = "Undo-DtcDiagnosticTransaction";
                }
                else if (c == 832)
                {
                    textBox1.Text = "Undo-Transaction";
                }
                else if (c == 833)
                {
                    textBox1.Text = "Uninstall-Package";
                }
                else if (c == 834)
                {
                    textBox1.Text = "Uninstall-ProvisioningPackage";
                }
                else if (c == 835)
                {
                    textBox1.Text = "Uninstall-TrustedProvisioningCertificate";
                }
                else if (c == 836)
                {
                    textBox1.Text = "Unprotect-CmsMessage";
                }
                else if (c == 837)
                {
                    textBox1.Text = "Unpublish-AppvClientPackage";
                }
                else if (c == 838)
                {
                    textBox1.Text = "Unregister-Event";
                }
                else if (c == 839)
                {
                    textBox1.Text = "Unregister-PackageSource";
                }
                else if (c == 840)
                {
                    textBox1.Text = "Unregister-PSSessionConfiguration";
                }
                else if (c == 841)
                {
                    textBox1.Text = "Unregister-ScheduledJob";
                }
                else if (c == 842)
                {
                    textBox1.Text = "Unregister-UevTemplate";
                }
                else if (c == 843)
                {
                    textBox1.Text = "Unregister-WindowsDeveloperLicense";
                }
                else if (c == 844)
                {
                    textBox1.Text = "Update-FormatData";
                }
                else if (c == 845)
                {
                    textBox1.Text = "Update-Help";
                }
                else if (c == 846)
                {
                    textBox1.Text = "Update-List";
                }
                else if (c == 847)
                {
                    textBox1.Text = "Update-TypeData";
                }
                else if (c == 848)
                {
                    textBox1.Text = "Update-UevTemplate";
                }
                else if (c == 849)
                {
                    textBox1.Text = "Update-VMVersion";
                }
                else if (c == 850)
                {
                    textBox1.Text = "Update-WIMBootEntry";
                }
                else if (c == 851)
                {
                    textBox1.Text = "Use-Transaction";
                }
                else if (c == 852)
                {
                    textBox1.Text = "Use-WindowsUnattend";
                }
                else if (c == 853)
                {
                    textBox1.Text = "Wait-Debugger";
                }
                else if (c == 854)
                {
                    textBox1.Text = "Wait-Event";
                }
                else if (c == 855)
                {
                    textBox1.Text = "Wait-Job";
                }
                else if (c == 856)
                {
                    textBox1.Text = "Wait-Process";
                }
                else if (c == 857)
                {
                    textBox1.Text = "Wait-VM";
                }
                else if (c == 858)
                {
                    textBox1.Text = "Where-Object";
                }
                else if (c == 859)
                {
                    textBox1.Text = "Write-Debug";
                }
                else if (c == 860)
                {
                    textBox1.Text = "Write-Error";
                }
                else if (c == 861)
                {
                    textBox1.Text = "Write-EventLog";
                }
                else if (c == 862)
                {
                    textBox1.Text = "Write-Host";
                }
                else if (c == 863)
                {
                    textBox1.Text = "Write-Information";
                }
                else if (c == 864)
                {
                    textBox1.Text = "Write-Output";
                }
                else if (c == 865)
                {
                    textBox1.Text = "Write-Progress";
                }
                else if (c == 866)
                {
                    textBox1.Text = "Write-Verbose";
                }
                else if (c == 867)
                {
                    textBox1.Text = "Write-Warning";
                }
            }
        }
    }
}
