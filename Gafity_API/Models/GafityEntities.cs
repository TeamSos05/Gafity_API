using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Gafity_API.Models
{
    public partial class GafityEntities : DbContext
    {
        public GafityEntities()
            : base("name=GafityEntities")
        {
        }

        public virtual DbSet<artist> artists { get; set; }
        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<playlist> playlists { get; set; }
        public virtual DbSet<playlist_manager> playlist_manager { get; set; }
        public virtual DbSet<song> songs { get; set; }
        public virtual DbSet<song_manager> song_manager { get; set; }
        public virtual DbSet<user_gafity> user_gafity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<artist>()
                .Property(e => e.artist_name)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .Property(e => e.biography)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .Property(e => e.url_profile_pic)
                .IsUnicode(false);

            modelBuilder.Entity<artist>()
                .HasMany(e => e.song_manager)
                .WithRequired(e => e.artist)
                .HasForeignKey(e => e.artist_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<genre>()
                .Property(e => e.genre_name)
                .IsUnicode(false);

            modelBuilder.Entity<genre>()
                .HasMany(e => e.songs)
                .WithRequired(e => e.genre)
                .HasForeignKey(e => e.genre_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<playlist>()
                .Property(e => e.url_playlist_pic)
                .IsUnicode(false);

            modelBuilder.Entity<playlist>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<playlist>()
                .HasMany(e => e.playlist_manager)
                .WithRequired(e => e.playlist)
                .HasForeignKey(e => e.id_playlist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<song>()
                .Property(e => e.song_name)
                .IsUnicode(false);

            modelBuilder.Entity<song>()
                .Property(e => e.lyrics)
                .IsUnicode(false);

            modelBuilder.Entity<song>()
                .Property(e => e.url_song_pic)
                .IsUnicode(false);

            modelBuilder.Entity<song>()
                .Property(e => e.url_media)
                .IsUnicode(false);

            modelBuilder.Entity<song>()
                .HasMany(e => e.playlist_manager)
                .WithRequired(e => e.song)
                .HasForeignKey(e => e.id_song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<song>()
                .HasMany(e => e.song_manager)
                .WithRequired(e => e.song)
                .HasForeignKey(e => e.song_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user_gafity>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user_gafity>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user_gafity>()
                .Property(e => e.isVip)
                .IsUnicode(false);

            modelBuilder.Entity<user_gafity>()
                .Property(e => e.url_user_pic)
                .IsUnicode(false);

            modelBuilder.Entity<user_gafity>()
                .HasMany(e => e.playlists)
                .WithRequired(e => e.user_gafity)
                .WillCascadeOnDelete(false);
        }
    }
}
