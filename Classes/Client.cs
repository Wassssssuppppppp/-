﻿using System.ComponentModel.DataAnnotations;

namespace EfCoreTest1
{
    public class Client
    {
        [Key]
        public int Client_code { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Middle_name { get; set; }

        public long Phone { get; set; }

        public string Address { get; set; }

    }
}
