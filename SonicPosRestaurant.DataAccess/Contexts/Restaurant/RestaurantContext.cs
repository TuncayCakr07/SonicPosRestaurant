﻿using SonicPosRestaurant.DataAccess.Contexts.Base;
using SonicPosRestaurant.DataAccess.Mappings;
using SonicPosRestaurant.Entities.Tables;
using SonicPosRestaurant.Entities.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.DataAccess.Contexts.Restaurant
{
    public class RestaurantContext : BaseContext<RestaurantContext>
    {
        public RestaurantContext()
        {
            
        }
        public RestaurantContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantContext,RestaurantConfiguration>());
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<EkMalzeme> EkMalzemeler { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Adisyon> Adisyonlar { get; set; }
        public DbSet<EkMalzemeHareket> EkMalzemeHareketleri { get; set; }
        public DbSet<Garson> Garsonlar { get; set; }
        public DbSet<Masa> Masalar { get; set; }
        public DbSet<UrunHareket> UrunHareketleri { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<OdemeHareket> OdemeHareketleri { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                c.HasKey(e => e.Id);
                c.Property(e => e.Ekleyen).HasMaxLength(50);
                c.Property(e => e.Duzenleyen).HasMaxLength(50);
                c.Property(e => e.Aciklama).HasMaxLength(200);


                c.Property(e => e.Id).HasColumnName("Id");
                c.Property(e => e.Duzenleyen).HasColumnName("Duzenleyen");
                c.Property(e => e.Ekleyen).HasColumnName("Ekleyen");
                c.Property(e => e.Aciklama).HasColumnName("Aciklama");
                c.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlenmeTarihi");
                c.Property(e => e.EklenmeTarihi).HasColumnName("EklenmeTarihi");
            });
            //Urun İlişkileri
            modelBuilder.Entity<Porsiyon>().HasRequired(c => c.Urun).WithMany(c => c.Porsiyonlar).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<EkMalzeme>().HasRequired(c => c.Urun).WithMany(c => c.EkMalzemeler).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<Urun>().HasRequired(c => c.UrunGrup).WithOptional().Map(c => c.MapKey("UrunGrupId"));
            modelBuilder.Entity<Porsiyon>().HasRequired(c => c.Birim).WithOptional().Map(c => c.MapKey("BirimId"));

            //Musteri ilişkileri
            modelBuilder.Entity<Telefon>().HasRequired(c => c.Musteri).WithMany(c => c.Telefonlar).HasForeignKey(c => c.MusteriId);
            modelBuilder.Entity<Adres>().HasRequired(c => c.Musteri).WithMany(c => c.Adresler).HasForeignKey(c => c.MusteriId);
            modelBuilder.Entity<Adisyon>().HasOptional(c => c.Musteri).WithMany(c=>c.Adisyonlar).HasForeignKey(c=>c.MusteriId);

            //Masa İlişkileri
            modelBuilder.Entity<Masa>().HasRequired(c => c.Konum).WithOptional().Map(c => c.MapKey("KonumId"));
            modelBuilder.Entity<Adisyon>().HasOptional(c => c.Masa).WithMany().HasForeignKey(c => c.MasaId);
            //modelBuilder.Entity<Masa>().HasRequired(c => c.Adisyon).WithMany().HasForeignKey(c => c.AdisyonId);
            modelBuilder.Entity<Adisyon>().HasRequired(c=>c.Garson).WithMany().HasForeignKey(c => c.GarsonId);
            modelBuilder.Entity<UrunHareket>().HasRequired(c => c.Urun).WithMany(c => c.UrunHareketleri).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<UrunHareket>().HasRequired(c => c.Adisyon).WithMany().HasForeignKey(c => c.AdisyonId);
            modelBuilder.Entity<UrunHareket>().HasRequired(c => c.Adisyon).WithMany(c => c.UrunHareketleri).HasForeignKey(c => c.AdisyonId);
            modelBuilder.Entity<EkMalzemeHareket>().HasRequired(c => c.UrunHareket).WithMany(c => c.EkMalzemeHareketleri).HasForeignKey(c => c.UrunHareketId);
            modelBuilder.Entity<EkMalzemeHareket>().HasRequired(c => c.EkMalzeme).WithMany().HasForeignKey(c => c.EkMalzemeId);

            //OdemeHareketİlişkileri
            modelBuilder.Entity<OdemeHareket>().HasRequired(c => c.OdemeTuru).WithMany(c => c.OdemeHareketleri).HasForeignKey(c => c.OdemeId);
            modelBuilder.Entity<OdemeHareket>().HasRequired(c => c.Adisyon).WithMany(c => c.OdemeHareketleri).HasForeignKey(c => c.AdisyonId);
            modelBuilder.Entity<OdemeTuru>().HasRequired(c => c.OdemeTur).WithMany().HasForeignKey(c => c.OdemeTurId);

            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PorsiyonMap());
            modelBuilder.Configurations.Add(new EkMalzemeMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new TelefonMap());
            modelBuilder.Configurations.Add(new AdresMap());
            modelBuilder.Configurations.Add(new AdisyonMap());
            modelBuilder.Configurations.Add(new EkMalzemeHareketMap());
            modelBuilder.Configurations.Add(new GarsonMap());
            modelBuilder.Configurations.Add(new MasaMap());
            modelBuilder.Configurations.Add(new UrunHareketMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new OdemeHareketMap());

        }
    }
}
