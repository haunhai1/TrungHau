﻿using C1_3_webAPI.Models;

namespace C1_3_webAPI.Models
{
    public class Book_Author
    {
        public int ID { get; set; }
        public int? BookID { get; set; }
        public int? AuthorID { get; set; } // Thêm khóa ngoại đến bảng Authors
        public Book? Book { get; set; }
        public Authors? Author { get; set; } // Thêm thuộc tính Author
    }
}