﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspNetYemekTarifiSitesi
{
    public class sqlsinif
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=ASUSTIRIDYE\SQLEXPRESS;Initial Catalog=AspNetYemekTarifiSitesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}