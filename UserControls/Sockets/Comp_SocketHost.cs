using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextScrappy.UserControls.Sockets
{
    public partial class Comp_SocketHost : Component, IComp_SocketHost
    {




        private Control.ControlCollection? spawnPoint;
        private Control? spawnPoint_Control;




        // properties


        public Control.ControlCollection? SpawnPoint
        {
            get => spawnPoint;
            protected
            set
            {
                spawnPoint = value;
            }
        }

        public Control? SpawnPoint_Control
        {
            get => spawnPoint_Control;
            set
            {
                if (spawnPoint_Control != value)
                {
                    spawnPoint_Control = value;
                    if (spawnPoint_Control != null)
                        SpawnPoint = spawnPoint_Control.Controls;
                    else
                        SpawnPoint = null;
                }
            }
        }


        // status

        public bool HasSpawnPoint => SpawnPoint != null;
        public int SP_count => SpawnPoint != null ? SpawnPoint.Count : -1;

        // config

        Type SocketType { get; set; } = typeof(SocketCtrl_Task_cmd);






        // MAIN


        public Comp_SocketHost()
        {
            InitializeComponent();
        }

        public Comp_SocketHost(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        // Functions

        #region General

        public void UpdateDetails()
        {
            UpdateStatus();
            if (!DesignMode)
            {

            }
        }

        void UpdateStatus()
        {

        }

        #endregion

        #region Actions

        public void SpawnNewConsole()
        {

        }

        #endregion


        // auto-generated


    }
}
