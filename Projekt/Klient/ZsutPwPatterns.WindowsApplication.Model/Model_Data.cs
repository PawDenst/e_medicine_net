//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.WindowsApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public partial class Model : IData
    {
        public string SearchText
        {
            get { return this.searchText; }
            set
            {
                this.searchText = value;

                this.RaisePropertyChanged("SearchText");
            }
        }
        private string searchText;

        public List<NodeData> NodeList
        {
            get { return this.nodeList; }
            private set
            {
                this.nodeList = value;

                this.RaisePropertyChanged("NodeList");
            }
        }
        private List<NodeData> nodeList = new List<NodeData>();
        public List<DoctorRoomData> SelectionList
        {
            get { return this.SelectionList; }
            private set
            {
                this.selectionList = value;

                this.RaisePropertyChanged("SelectionList");
            }
        }
        
        private List<DoctorRoomData> selectionList = new List<DoctorRoomData>();

        public NodeData SelectedNode
        {
            get { return this.selectedNode; }
            set
            {
                this.selectedNode = value;

                this.RaisePropertyChanged("SelectedNode");
            }
        }
        private NodeData selectedNode;
        public DoctorRoomData SelectedDoctorRoomData
        {
            get { return this.selectedDoctorRoomData; }
            set
            {
                this.selectedDoctorRoomData = value;

                this.RaisePropertyChanged("SelectedDoctorRoomData");
            }
        }
        private DoctorRoomData selectedDoctorRoomData;



    }
}
