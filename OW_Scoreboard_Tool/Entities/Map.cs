﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OW_Scoreboard_Tool.Entities
{
    public class Map
    {
        #region Properties
        private string _name = "";
        private Gametype _gametype = new Gametype();
        private Bitmap _icon = Properties.Resources.Icon_none;
        private Bitmap _wide = Properties.Resources.Icon_none;
        private string _introPath = "";

        public string Name { get => _name; set => _name = value; }
        public Gametype Gametype { get => _gametype; set => _gametype = value; }
        [XmlIgnore]
        public Bitmap Icon { get => _icon; set => _icon = value; }
        [XmlIgnore]
        public Bitmap Wide { get => _wide; set => _wide = value; }
        public string IntroPath { get => _introPath; set => _introPath = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Map()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="gametype"></param>
        /// <param name="icon"></param>
        /// <param name="wide"></param>
        /// <param name="introPath"></param>
        public Map(string name, Gametype gametype, Bitmap icon, Bitmap wide, string introPath)
        {
            _name = name;
            _gametype = gametype;
            _icon = icon;
            _wide = wide;
            _introPath = introPath;
        }
        #endregion
    }
}
