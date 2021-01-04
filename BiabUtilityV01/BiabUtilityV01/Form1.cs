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

                SortedList<string, string> myFolderList = new SortedList<string, string>()
                {
                    { @"C:\bb\Artist Video Performance Sets", string.Empty },
                    { @"C:\bb\Instrumental Studies", string.Empty },
                    { @"C:\bb\20 Tunes - Blues Guitar Vol. 2", string.Empty },
                    { @"C:\bb\Songs and Lessons\20 Tunes - Blues Guitar Vol. 2", string.Empty },
                    { @"C:\bb\20 Tunes - Jazz Guitar Vol. 3", string.Empty },
                    { @"C:\bb\Songs and Lessons\20 Tunes - Jazz Guitar Vol. 3", string.Empty },
                    { @"C:\bb\20 Tunes - Rock Guitar Vol. 2", string.Empty },
                    { @"C:\bb\Songs and Lessons\20 Tunes - Rock Guitar Vol. 2", string.Empty },
                    { @"C:\bb\101 Guitar Comping - High Strings", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Guitar Comping - High Strings", string.Empty },
                    { @"C:\bb\101 Guitar Comping - Low Strings", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Guitar Comping - Low Strings", string.Empty },
                    { @"C:\bb\101 Riffs - Blues Guitar Vol. 1", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Blues Guitar Vol. 1", string.Empty },
                    { @"C:\bb\101 Riffs - Rock Guitar Vol. 1", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Rock Guitar Vol. 1", string.Empty },
                    { @"C:\bb\50SONGS", string.Empty },
                    { @"C:\bb\Songs and Lessons\50SONGS", string.Empty },
                    { @"C:\bb\101 Riffs - Bluegrass Guitar", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Bluegrass Guitar", string.Empty },
                    { @"C:\bb\101 Riffs - Blues Piano", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Blues Piano", string.Empty },
                    { @"C:\bb\101 Riffs - Country Guitar with Audio Memos", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Country Guitar with Audio Memos", string.Empty },
                    { @"C:\bb\101 Riffs - Jazz (All instruments)", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Jazz (All instruments)", string.Empty },
                    { @"C:\bb\101 Riffs - Jazz Guitar Phrases", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Jazz Guitar Phrases", string.Empty },
                    { @"C:\bb\101 Riffs - Jazz Piano", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs - Jazz Piano", string.Empty },
                    { @"C:\bb\101 Riffs -Solo Intros", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs -Solo Intros", string.Empty },
                    { @"C:\bb\101 Riffs -Trio Intros", string.Empty },
                    { @"C:\bb\Songs and Lessons\101 Riffs -Trio Intros", string.Empty },
                    { @"C:\bb\BLUEJAMC", string.Empty },
                    { @"C:\bb\BLUEJAMF", string.Empty },
                    { @"C:\bb\BGFAKE", string.Empty },
                    { @"C:\bb\Songs and Lessons\BGFAKE", string.Empty },
                    { @"C:\bb\bpsolos", string.Empty },
                    { @"C:\bb\Songs and Lessons\bpsolos", string.Empty },
                    { @"C:\bb\CGSOLOS", string.Empty },
                    { @"C:\bb\Songs and Lessons\CGSOLOS", string.Empty },
                    { @"C:\bb\CLASFAKE", string.Empty },
                    { @"C:\bb\Songs and Lessons\CLASFAKE", string.Empty },
                    { @"C:\bb\Classical MIDI-FakeBook3", string.Empty },
                    { @"C:\bb\Songs and Lessons\Classical MIDI-FakeBook3", string.Empty },
                    { @"C:\bb\Classical MIDI-Fakebook 2", string.Empty },
                    { @"C:\bb\Songs and Lessons\Classical MIDI-Fakebook 2", string.Empty },
                    { @"C:\bb\CopyMe", string.Empty },
                    { @"C:\bb\Songs and Lessons\CopyMe", string.Empty },
                    { @"C:\bb\Duets for Sight Reading", string.Empty },
                    { @"C:\bb\Songs and Lessons\Duets for Sight Reading", string.Empty },
                    { @"C:\bb\Ear Training", string.Empty },
                    { @"C:\bb\FGSOLO50", string.Empty },
                    { @"C:\bb\Songs and Lessons\FGSOLO50", string.Empty },
                    { @"C:\bb\Folk Songs", string.Empty },
                    { @"C:\bb\Songs and Lessons\Folk Songs", string.Empty },
                    { @"C:\bb\Jazz Guitar Solos - Swingin Vol 4", string.Empty },
                    { @"C:\bb\Songs and Lessons\Jazz Guitar Solos - Swingin Vol 4", string.Empty },
                    { @"C:\bb\JAZZPRAC", string.Empty },
                    { @"C:\bb\JGSOLOS", string.Empty },
                    { @"C:\bb\Songs and Lessons\JGSOLOS", string.Empty },
                    { @"C:\bb\Novelty Piano Riffs", string.Empty },
                    { @"C:\bb\Songs and Lessons\Novelty Piano Riffs", string.Empty },
                    { @"C:\bb\Swingin' Jazz Piano Solos", string.Empty },
                    { @"C:\bb\Songs and Lessons\Swingin' Jazz Piano Solos", string.Empty },
                    { @"C:\bb\Soundtrack MIDI Fakebook", string.Empty },
                    { @"C:\bb\Tutorial - BB 2006", string.Empty },
                    { @"C:\bb\Tutorial - BB2012", string.Empty },
                    { @"C:\bb\Tutorial - Repeats and Endings", string.Empty },
                    { @"C:\bb\Artist Performance Sets", string.Empty },
                    { @"test", string.Empty },
                };

                int myCountTotal = myFolderList.Count();
                int myCountExisting = 0;
                int myCountCreated = 0;

                foreach (KeyValuePair<string, string> myFolder in myFolderList)
                {
                    string myKey = (myFolder.Key + string.Empty).Trim();
                    string myValue = (myFolder.Value + string.Empty).Trim();

                    if (Directory.Exists(myKey.Trim()))
                    {
                        myCountExisting = myCountExisting + 1;
                    }
                    else
                    {
                        Directory.CreateDirectory(myKey.Trim());
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
