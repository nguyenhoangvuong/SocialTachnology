﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FivePSocialNetwork.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FivePSocialNetWorkEntities : DbContext
    {
        public FivePSocialNetWorkEntities()
            : base("name=FivePSocialNetWorkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Comment_Answer> Comment_Answer { get; set; }
        public virtual DbSet<Commune> Communes { get; set; }
        public virtual DbSet<Denounce_User> Denounce_User { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Image_Advertisement> Image_Advertisement { get; set; }
        public virtual DbSet<Letter> Letters { get; set; }
        public virtual DbSet<Letters_Idea> Letters_Idea { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Position_Advertisement> Position_Advertisement { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Provincial> Provincials { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Rate_Answer> Rate_Answer { get; set; }
        public virtual DbSet<Rate_Post> Rate_Post { get; set; }
        public virtual DbSet<Rate_Question> Rate_Question { get; set; }
        public virtual DbSet<Regulation> Regulations { get; set; }
        public virtual DbSet<Role_User> Role_User { get; set; }
        public virtual DbSet<Search> Searches { get; set; }
        public virtual DbSet<Sex_User> Sex_User { get; set; }
        public virtual DbSet<Show_Activate_Question> Show_Activate_Question { get; set; }
        public virtual DbSet<Tags_Question> Tags_Question { get; set; }
        public virtual DbSet<Teachnology_Question> Teachnology_Question { get; set; }
        public virtual DbSet<Teachnology_User> Teachnology_User { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<Tick_Question> Tick_Question { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<View_Post> View_Post { get; set; }
        public virtual DbSet<View_Question> View_Question { get; set; }
        public virtual DbSet<User_IP> User_IP { get; set; }
        public virtual DbSet<Functions_User> Functions_User { get; set; }
    }
}
