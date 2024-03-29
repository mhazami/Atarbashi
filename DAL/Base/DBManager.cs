﻿using Atarbashi.DataStructure;
using System.Data.Entity;

namespace Atarbashi.DAL.Base
{
    public class DBManager : DbContext
    {
        public DBManager() : base("name=ConnectionString") { }

        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<Role> Role { get; set; }

        public virtual DbSet<UserRole> UserRole { get; set; }

        public virtual DbSet<Article> Article { get; set; }

        public virtual DbSet<ArticleCategory> ArticleCategory { get; set; }

        public virtual DbSet<EnterPriseNode> EnterPriseNode { get; set; }

        public virtual DbSet<Customer> Customer { get; set; }

        public virtual DbSet<File> File { get; set; }

        public virtual DbSet<ItemCategory> ItemCategory { get; set; }

        public virtual DbSet<Menu> Menu { get; set; }

        public virtual DbSet<Newsletter> Newsletter { get; set; }

        public virtual DbSet<RoleMenu> RoleMenu { get; set; }

        public virtual DbSet<UserComments> UserComments { get; set; }

        public virtual DbSet<Message> Message { get; set; }

        public virtual DbSet<GalleryItem> GalleryItem { get; set; }

        public virtual DbSet<Slider> Slider { get; set; }

        public virtual DbSet<Gallery> Gallery { get; set; }
    }
}
