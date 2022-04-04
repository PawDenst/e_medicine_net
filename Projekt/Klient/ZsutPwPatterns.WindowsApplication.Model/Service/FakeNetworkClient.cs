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
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using ZsutPwPatterns.WindowsApplication.Model.Data;

    public class FakeNetworkClient : INetwork
    {
        private static readonly NodeData[] nodes = new NodeData[] { new NodeData() { Id = "node1", Position = new PointData() { X = 0, Y = 0 } }, new NodeData() { Id = "node2", Position = new PointData() { X = 1, Y = 1 } } };
        private static readonly Dictionary<string, string> fakeDicitionary = new Dictionary<string, string> { { "Kowalski", "1" }, { "Nowak", "2" } };





        public NodeData[] GetNodes(string searchText)
        {
            return FakeNetworkClient.nodes;
        }

        public List<DoctorRoomData> GetSelectionList()
        {
            List<DoctorRoomData> data = new List<DoctorRoomData>();

            foreach (KeyValuePair<string, string> selection in fakeDicitionary)
            {
                DoctorRoomData dataExample = new DoctorRoomData() { Surname = selection.Key, Number = selection.Value };
                data.Add(dataExample);


            }
            return data;
        }
    }
}
