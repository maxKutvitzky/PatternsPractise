﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PatternsPractise.Connection;
using PatternsPractise.Entities;
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.User;

namespace PatternsPractise
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            /*MySqlConnection connection = SQLConnection.GetConnection("localhost","gamelibrarydb",3306,"root","root");
            
            try
            {
                connection.Open();
                connectionLabel.Text = "Подключение: подключено; База данных: "+connection.Database;
                connection.Close();
            }
            catch(Exception ex)
            {
                connectionLabel.Text = "Подключение: "+ ex.Message;
            }
            */
            /*Game game = new GameBuilder()
                .gameName("bf5")
                .gameDeveloper("ea")
                .gamePublisher("ea")
                .gamePrice(60)
                .gameDateOfRelease("20.10.2015")
                .AddGenreBuilder(new GameGenre("shooter"))
                .AddGenreBuilder(new GameGenre("horror"))
                .Build();
            connectionLabel.Text = game.ToString();*/
            User user = new UserBuilder(1)
                .userName("Максим")
                .userSurname("Кутвицкий")
                .userMiddleName("Юрьевич")
                .userLogin("user")
                .userPassword("password")
                .userPhone("0960039001")
                .userDescription("додик")
                .Build();
            connectionLabel.Text = user.ToString();
        }
    }
}
