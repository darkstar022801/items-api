﻿//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Items.Data.Entities
//{
//    [Table("Recipes", Schema = "Food")]
//    public class Recipe
//    {
//        [Key]
//        public Guid Id { get; set; }

//        public string Name { get; set; }

//        public int Servings { get; set; }

//        public Guid CreatedBy { get; set; }

//        public DateTime CreatedDate { get; set; }

//        public Guid? UpdatedBy { get; set; }

//        public DateTime? UpdatedDate { get; set; }

//        public Guid? DeletedBy { get; set; }

//        public DateTime? DeletedDate { get; set; }


//        [ForeignKey("CreatedBy")]
//        public virtual User Creator { get; set; }

//        [ForeignKey("UpdatedBy")]
//        public virtual User Updator { get; set; }

//        [ForeignKey("DeletedBy")]
//        public virtual User Deletor { get; set; }
//    }
//}
