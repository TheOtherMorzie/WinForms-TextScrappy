using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFFT_Lib.Components;
using Timer = System.Windows.Forms.Timer;

namespace TextScrappy.UserControls.Sockets
{
    public partial class SocketHost_CMD : Component, IComp_SocketHost
    {
        public SocketHost_CMD()
        {
            InitializeComponent();
        }

        public SocketHost_CMD(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


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
        List<SocketCtrl_Task_cmd> sockets = new();


        // Functions

        #region General

        public void UpdateDetails()
        {
            UpdateStatus();
            if (!DesignMode)
            {
                if (sockets.Count > 0)
                    sockets.ForEach(s => s.CheckLog());
            }
        }

        void UpdateStatus()
        {

        }

        #endregion

        #region Actions

        public void SpawnNewConsole(string command)
        {
            if (!DesignMode && HasSpawnPoint)
            {
                SocketCtrl_Task_cmd control = new SocketCtrl_Task_cmd();
                sockets.Add(control);


                SpawnPoint.Add(control);

                //control.AutoSize = true;
                control.HideDetailsPanel = true;

                control.RunCommand(command);
            }
        }

        #endregion


        // auto-generated



    }
}
