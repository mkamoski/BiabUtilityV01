using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiabUtilityV01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddMissingFoldersButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.MessageTextBox.Text = string.Empty;

                List<string> myFolderList = new List<string>()
                {
                    @"C:\bb\Artist Video Performance Sets",
                    @"C:\bb\Instrumental Studies",
                    @"C:\bb\20 Tunes - Blues Guitar Vol. 2",
                    @"C:\bb\Songs and Lessons\20 Tunes - Blues Guitar Vol. 2",
                    @"C:\bb\20 Tunes - Jazz Guitar Vol. 3",
                    @"C:\bb\Songs and Lessons\20 Tunes - Jazz Guitar Vol. 3",
                    @"C:\bb\20 Tunes - Rock Guitar Vol. 2",
                    @"C:\bb\Songs and Lessons\20 Tunes - Rock Guitar Vol. 2",
                    @"C:\bb\101 Guitar Comping - High Strings",
                    @"C:\bb\Songs and Lessons\101 Guitar Comping - High Strings",
                    @"C:\bb\101 Guitar Comping - Low Strings",
                    @"C:\bb\Songs and Lessons\101 Guitar Comping - Low Strings",
                    @"C:\bb\101 Riffs - Blues Guitar Vol. 1",
                    @"C:\bb\Songs and Lessons\101 Riffs - Blues Guitar Vol. 1",
                    @"C:\bb\101 Riffs - Rock Guitar Vol. 1",
                    @"C:\bb\Songs and Lessons\101 Riffs - Rock Guitar Vol. 1",
                    @"C:\bb\50SONGS",
                    @"C:\bb\Songs and Lessons\50SONGS",
                    @"C:\bb\101 Riffs - Bluegrass Guitar",
                    @"C:\bb\Songs and Lessons\101 Riffs - Bluegrass Guitar",
                    @"C:\bb\101 Riffs - Blues Piano",
                    @"C:\bb\Songs and Lessons\101 Riffs - Blues Piano",
                    @"C:\bb\101 Riffs - Country Guitar with Audio Memos",
                    @"C:\bb\Songs and Lessons\101 Riffs - Country Guitar with Audio Memos",
                    @"C:\bb\101 Riffs - Jazz (All instruments)",
                    @"C:\bb\Songs and Lessons\101 Riffs - Jazz (All instruments)",
                    @"C:\bb\101 Riffs - Jazz Guitar Phrases",
                    @"C:\bb\Songs and Lessons\101 Riffs - Jazz Guitar Phrases",
                    @"C:\bb\101 Riffs - Jazz Piano",
                    @"C:\bb\Songs and Lessons\101 Riffs - Jazz Piano",
                    @"C:\bb\101 Riffs -Solo Intros",
                    @"C:\bb\Songs and Lessons\101 Riffs -Solo Intros",
                    @"C:\bb\101 Riffs -Trio Intros",
                    @"C:\bb\Songs and Lessons\101 Riffs -Trio Intros",
                    @"C:\bb\BLUEJAMC",
                    @"C:\bb\BLUEJAMF",
                    @"C:\bb\BGFAKE",
                    @"C:\bb\Songs and Lessons\BGFAKE",
                    @"C:\bb\bpsolos",
                    @"C:\bb\Songs and Lessons\bpsolos",
                    @"C:\bb\CGSOLOS",
                    @"C:\bb\Songs and Lessons\CGSOLOS",
                    @"C:\bb\CLASFAKE",
                    @"C:\bb\Songs and Lessons\CLASFAKE",
                    @"C:\bb\Classical MIDI-FakeBook3",
                    @"C:\bb\Songs and Lessons\Classical MIDI-FakeBook3",
                    @"C:\bb\Classical MIDI-Fakebook 2",
                    @"C:\bb\Songs and Lessons\Classical MIDI-Fakebook 2",
                    @"C:\bb\CopyMe",
                    @"C:\bb\Songs and Lessons\CopyMe",
                    @"C:\bb\Duets for Sight Reading",
                    @"C:\bb\Songs and Lessons\Duets for Sight Reading",
                    @"C:\bb\Ear Training",
                    @"C:\bb\FGSOLO50",
                    @"C:\bb\Songs and Lessons\FGSOLO50",
                    @"C:\bb\Folk Songs",
                    @"C:\bb\Songs and Lessons\Folk Songs",
                    @"C:\bb\Jazz Guitar Solos - Swingin Vol 4",
                    @"C:\bb\Songs and Lessons\Jazz Guitar Solos - Swingin Vol 4",
                    @"C:\bb\JAZZPRAC",
                    @"C:\bb\JGSOLOS",
                    @"C:\bb\Songs and Lessons\JGSOLOS",
                    @"C:\bb\Novelty Piano Riffs",
                    @"C:\bb\Songs and Lessons\Novelty Piano Riffs",
                    @"C:\bb\Swingin' Jazz Piano Solos",
                    @"C:\bb\Songs and Lessons\Swingin' Jazz Piano Solos",
                    @"C:\bb\Soundtrack MIDI Fakebook",
                };

                int myCountTotal = myFolderList.Count();
                int myCountExisting = 0;
                int myCountCreated = 0;

                foreach(string myFolder in myFolderList)
                {
                    if (Directory.Exists(myFolder.Trim()))
                    {
                        myCountExisting = myCountExisting + 1;
                    }
                    else
                    { 
                        Directory.CreateDirectory(myFolder.Trim());
                        myCountCreated = myCountCreated + 1;
                    }
                }

                this.MessageTextBox.Text = string.Empty + 
                    " DateTime.Now.ToString(\"o\")='" + DateTime.Now.ToString("o") + "'" + 
                    " and Status='" + "Ok" + "'" +  
                    " and MethodBase.GetCurrentMethod().Name='" + MethodBase.GetCurrentMethod().Name + "'" + 
                    " and myCountExisting='" + myCountExisting + "'" +
                    " and myCountCreated='" + myCountCreated + "'" +
                    " and myCountTotal='" + myCountTotal + "'" +
                    string.Empty;
            }
            catch (Exception ex)
            {
                this.MessageTextBox.Text = DateTime.Now.ToString("o") + " | " + "Error and ex.ToString()='" + ex.ToString() + "' here.";
            }
        }
    }
}
