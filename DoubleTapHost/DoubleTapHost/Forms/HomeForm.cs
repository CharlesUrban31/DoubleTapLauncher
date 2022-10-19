using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DoubleTapHost
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        /* --------------------------------------------------------------------------------
         * Launch Server
         * ================================================================================
         * This function calls Server.Launch, which will open a server listener and begin
         * listening for clients trying to connect.
         * --------------------------------------------------------------------------------
         */
        private void serverLaunchBtn_Click(object sender, EventArgs e)
        {
            consoleLogBox.AppendText("[SERVER] Starting...\r\n");
            consoleLogBox.ScrollToCaret();
            // Start Server
            //Server.startServer(ref consoleLogBox);

            consoleLogBox.AppendText("[SERVER] Server Ready\r\n");
            consoleLogBox.ScrollToCaret();
        }

        /* --------------------------------------------------------------------------------
         * Close Server
         * ================================================================================
         * This function calls the Server.Close command. This command disconnects all
         * current client connections and then closes the server.
         * --------------------------------------------------------------------------------
         */
        private void serverCloseBtn_Click(object sender, EventArgs e)
        {
            consoleLogBox.AppendText("[SERVER] Closing All Connections...\r\n");
            consoleLogBox.ScrollToCaret();
            // Close Server
            Server.closeServer();

            consoleLogBox.AppendText("[SERVER] Server Closed\r\n");
            consoleLogBox.ScrollToCaret();
        }

        /* --------------------------------------------------------------------------------
         * View Server Connections
         * ================================================================================
         * This function prints out every client that is currently connected to the server
         * --------------------------------------------------------------------------------
         */
        private void viewConnBtn_Click(object sender, EventArgs e)
        {
            consoleLogBox.AppendText("[SERVER] Current Devices Connected...\r\n");
            consoleLogBox.ScrollToCaret();
            // Print Current Connected Devices
            String[] connections = Server.getConnections();
            foreach (string connection in connections)
            {
                consoleLogBox.AppendText(connection + "\r\n");
                consoleLogBox.ScrollToCaret();
            }
        }

        /* --------------------------------------------------------------------------------
         * List Games Button Click
         * ================================================================================
         * This function will go through and print out every game currently in the game 
         * library to the in-window consoleLogBox.
         * --------------------------------------------------------------------------------
         */
        private void listGamesBtn_Click(object sender, EventArgs e)
        {
            consoleLogBox.AppendText("[APPLICATION] Games In Library...\r\n");
            consoleLogBox.ScrollToCaret();
            //}
        }

        /* --------------------------------------------------------------------------------
         * MENU BAR BUTTON FUNCTIONS
         * -------------------------------------------------------------------------------- */

        /* --------------------------------------------------------------------------------
         * Exit Button
         * ================================================================================
         * This button click closes the application, along with calling Server.Close to
         * close any current server connections.
         * --------------------------------------------------------------------------------
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.closeServer();
            Application.Exit();
        }

        /* --------------------------------------------------------------------------------
         * About Button
         * ================================================================================
         * This button will open up an aboutBox form to show the details of the application.
         * --------------------------------------------------------------------------------
         */
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
            aboutBox.Focus();
        }

        /* --------------------------------------------------------------------------------
         * Locate Library Button
         * ================================================================================
         * This button opens a folder browser dialog, this is used to change the location
         * of where games are searched for.
         * --------------------------------------------------------------------------------
         */
        private void libraryLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                String libraryLocation = menuFolderBrowser.SelectedPath;
            }
        }

        private void viewHostDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
