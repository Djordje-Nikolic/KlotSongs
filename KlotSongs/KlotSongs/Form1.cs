﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlotSongs.Models;
using KlotSongs.Services;
using MongoDB.Bson;

namespace KlotSongs
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DBService database = new DBService();
		}
	}
}
