namespace MvcMovie.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<DangAn> DangAns { get; set; }
        public virtual DbSet<DangAnState> DangAnStates { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<FanKui> FanKuis { get; set; }
        public virtual DbSet<JianLi> JianLis { get; set; }
        public virtual DbSet<MianShi> MianShis { get; set; }
        public virtual DbSet<PeiXunJiHua> PeiXunJiHuas { get; set; }
        public virtual DbSet<QuanXian> QuanXians { get; set; }
        public virtual DbSet<Roleinfo> Roleinfoes { get; set; }
        public virtual DbSet<ShenHe> ShenHes { get; set; }
        public virtual DbSet<ShenHeRen> ShenHeRens { get; set; }
        public virtual DbSet<ShiTi> ShiTis { get; set; }
        public virtual DbSet<ShiTiLei> ShiTiLeis { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<XinChou> XinChous { get; set; }
        public virtual DbSet<XinChouDetail> XinChouDetails { get; set; }
        public virtual DbSet<XinChouXiangMu> XinChouXiangMus { get; set; }
        public virtual DbSet<ZhiWei> ZhiWeis { get; set; }
        public virtual DbSet<ZhiWeiFaBu> ZhiWeiFaBus { get; set; }
        public virtual DbSet<ZhiWeiFenLei> ZhiWeiFenLeis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangAn>()
                .Property(e => e.ImgPath)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.SuoZaiDi)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.MianMao)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.ShenFenZheng)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.BiYe)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.XueLi)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.ZhuanYe)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.YinHang)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.YinHangKaHao)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.SheBaoKaHao)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.LVLi)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.JiaTingXinXi)
                .IsUnicode(false);

            modelBuilder.Entity<DangAn>()
                .Property(e => e.BeiZhu)
                .IsUnicode(false);

            modelBuilder.Entity<DangAnState>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DangAnState>()
                .HasMany(e => e.DangAns)
                .WithOptional(e => e.DangAnState)
                .HasForeignKey(e => e.DangAnZhuangTai);

            modelBuilder.Entity<Department>()
                .Property(e => e.DJianCheng)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Dname)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Departments1)
                .WithOptional(e => e.Department1)
                .HasForeignKey(e => e.ParentDepartment);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => e.DID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.ZhiWeis)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DID);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.ZhiWeiFaBus)
                .WithOptional(e => e.Department)
                .HasForeignKey(e => e.DID);

            modelBuilder.Entity<FanKui>()
                .Property(e => e.ZongJie)
                .IsUnicode(false);

            modelBuilder.Entity<FanKui>()
                .Property(e => e.JieGuo)
                .IsUnicode(false);

            modelBuilder.Entity<FanKui>()
                .HasMany(e => e.PeiXunJiHuas)
                .WithOptional(e => e.FanKui)
                .HasForeignKey(e => e.FKID);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.JName)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.ZhaoPingLeiXing)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.SuoZaiDi)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.MianMao)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.ShenFenZheng)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.BiYe)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.XueLi)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.ZhuanYe)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.JingYan)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.XinZiYaoQiu)
                .IsUnicode(false);

            modelBuilder.Entity<JianLi>()
                .Property(e => e.LVLi)
                .IsUnicode(false);

            modelBuilder.Entity<MianShi>()
                .Property(e => e.YiComment)
                .IsUnicode(false);

            modelBuilder.Entity<MianShi>()
                .Property(e => e.ErComment)
                .IsUnicode(false);

            modelBuilder.Entity<MianShi>()
                .Property(e => e.SanComment)
                .IsUnicode(false);

            modelBuilder.Entity<MianShi>()
                .HasMany(e => e.JianLis)
                .WithOptional(e => e.MianShi)
                .HasForeignKey(e => e.MID);

            modelBuilder.Entity<PeiXunJiHua>()
                .Property(e => e.PXName)
                .IsUnicode(false);

            modelBuilder.Entity<PeiXunJiHua>()
                .Property(e => e.Teacher)
                .IsUnicode(false);

            modelBuilder.Entity<QuanXian>()
                .Property(e => e.OpenHtml)
                .IsUnicode(false);

            modelBuilder.Entity<QuanXian>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<QuanXian>()
                .HasMany(e => e.QuanXian1)
                .WithOptional(e => e.QuanXian2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<QuanXian>()
                .HasMany(e => e.Roleinfoes)
                .WithMany(e => e.QuanXians)
                .Map(m => m.ToTable("UserRole").MapLeftKey("QID").MapRightKey("RID"));

            modelBuilder.Entity<Roleinfo>()
                .Property(e => e.Rolename)
                .IsUnicode(false);

            modelBuilder.Entity<Roleinfo>()
                .HasMany(e => e.Roleinfo1)
                .WithOptional(e => e.Roleinfo2)
                .HasForeignKey(e => e.ParentRole);

            modelBuilder.Entity<Roleinfo>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roleinfo)
                .HasForeignKey(e => e.RID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShenHe>()
                .HasMany(e => e.ShenHeRens)
                .WithRequired(e => e.ShenHe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShenHeRen>()
                .Property(e => e.ShenHeYiJian)
                .IsUnicode(false);

            modelBuilder.Entity<ShiTi>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<ShiTi>()
                .Property(e => e.ChutiRenRong)
                .IsUnicode(false);

            modelBuilder.Entity<ShiTi>()
                .Property(e => e.Sinfo)
                .IsUnicode(false);

            modelBuilder.Entity<ShiTiLei>()
                .Property(e => e.SName)
                .IsUnicode(false);

            modelBuilder.Entity<ShiTiLei>()
                .HasMany(e => e.ShiTis)
                .WithOptional(e => e.ShiTiLei)
                .HasForeignKey(e => e.STLID);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PassWord)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DangAns)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.DengJiRen);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MianShis)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ErUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MianShis1)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.SanUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.MianShis2)
                .WithRequired(e => e.User2)
                .HasForeignKey(e => e.YiUID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ShenHes)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.TiJiaoRen);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ShenHeRens)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ShenHeRen1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ShiTis)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.XinChous)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.DengJiRen);

            modelBuilder.Entity<User>()
                .HasMany(e => e.XinChous1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.ZhiDingRen);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ZhiWeiFaBus)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.DengJiRen);

            modelBuilder.Entity<XinChou>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<XinChou>()
                .HasMany(e => e.DangAns)
                .WithOptional(e => e.XinChou)
                .HasForeignKey(e => e.XID);

            modelBuilder.Entity<XinChou>()
                .HasMany(e => e.XinChouDetails)
                .WithRequired(e => e.XinChou)
                .HasForeignKey(e => e.XCID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XinChouXiangMu>()
                .Property(e => e.XMName)
                .IsUnicode(false);

            modelBuilder.Entity<XinChouXiangMu>()
                .HasMany(e => e.XinChouDetails)
                .WithRequired(e => e.XinChouXiangMu)
                .HasForeignKey(e => e.XMID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZhiWei>()
                .Property(e => e.ZName)
                .IsUnicode(false);

            modelBuilder.Entity<ZhiWei>()
                .Property(e => e.Zinfo)
                .IsUnicode(false);

            modelBuilder.Entity<ZhiWei>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ZhiWei>()
                .HasMany(e => e.DangAns)
                .WithOptional(e => e.ZhiWei)
                .HasForeignKey(e => e.ZWID);

            modelBuilder.Entity<ZhiWei>()
                .HasMany(e => e.JianLis)
                .WithOptional(e => e.ZhiWei)
                .HasForeignKey(e => e.ZWID);

            modelBuilder.Entity<ZhiWei>()
                .HasMany(e => e.ZhiWeiFaBus)
                .WithOptional(e => e.ZhiWei)
                .HasForeignKey(e => e.ZID);

            modelBuilder.Entity<ZhiWeiFaBu>()
                .Property(e => e.MiaoShu)
                .IsUnicode(false);

            modelBuilder.Entity<ZhiWeiFaBu>()
                .Property(e => e.YaoQiu)
                .IsUnicode(false);

            modelBuilder.Entity<ZhiWeiFenLei>()
                .Property(e => e.ZWFLName)
                .IsUnicode(false);

            modelBuilder.Entity<ZhiWeiFenLei>()
                .HasMany(e => e.ZhiWeis)
                .WithOptional(e => e.ZhiWeiFenLei)
                .HasForeignKey(e => e.ZWFLID);
        }
    }
}
