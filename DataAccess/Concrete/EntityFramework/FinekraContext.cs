using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class FinekraContext : DbContext
	{
		public FinekraContext(DbContextOptions options) : base(options) { }

		public DbSet<Brand> Brands { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }
		public DbSet<Perfume> Perfumes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Brand>(
				brand =>
				{
					brand.HasData(new
					{
						BrandId = 1,
						BrandName = "Armani",
						Description = "Giorgio Armani, founded by the renowned Italian designer Giorgio Armani, masterfully marries timeless elegance with modern sophistication."
					});

					brand.HasData(new
					{
						BrandId = 2,
						BrandName = "Burberry",
						Description = "Burberry originated as the inventor of the trench coat, but it is now best known for its fresh, high-quality fragrances."
					});

					brand.HasData(new
					{
						BrandId = 3,
						BrandName = "Calvin Klein",
						Description = "Calvin Klein fragrances generally have fresh, distinctive scents that are pleasing to both men and women."
					});

					brand.HasData(new
					{
						BrandId = 4,
						BrandName = "Hugo Boss",
						Description = "Hugo Boss is an emblematic German brand, recognized for seamlessly blending modern allure with timeless sophistication."
					});

					brand.HasData(new
					{
						BrandId = 5,
						BrandName = "Chanel",
						Description = "Each CHANEL fragrance for women is inspired by Mademoiselle's world, and in turn creates its own imaginative and feminine olfactory experience. "
					});

					brand.HasData(new
					{
						BrandId = 6,
						BrandName = "Dolce Gabbana",
						Description = "From the warm spicy, amber, and aromatic accords of D&G's The One for Men Eau de Parfum (2015) cologne to the citrusy and musk notes of Light Blue Eau Intense (2017) perfume."

					});

					brand.HasData(new
					{
						BrandId = 7,
						BrandName = "Versace",
						Description = "Italian designer Gianni Versace’s entry into the world of fashion in 1978 became a gamechanger for the industry."
					});


				}
				);

			modelBuilder.Entity<UserDetail>(

				userDetail =>
				{
					userDetail.HasData(new
					{
						UserDetailId = 1,
						UserName = "ertasofficial",
						Address = "Zafer Mahallesi Kayalık Sokak No:69/5 Tepebaşı/ESKİŞEHİR",
						Phone = "05452158345",
						Email = "rtsahmet26@gmail.com",
						LastName = "ERTAŞ",
						FirstName = "Ahmet"

					});

					userDetail.HasData(new
					{
						UserDetailId = 2,
						UserName = "rofficial",
						Address = "Zafer Mahallesi Kayalık Sokak No:69/5 Tepebaşı/ESKİŞEHİR",
						Phone = "05432708624",
						Email = "nstertas@gmail.com",
						LastName = "ERTAŞ",
						FirstName = "Rasim"
					});
				}

				);

			modelBuilder.Entity<Perfume>(

				perfume =>
				{
					perfume.HasData(new
					{
						PerfumeId = 1,
						PerfumeName = "Gabriel",
						BrandId = 1,
						Price = 15000.2m,
						PhotoPath = "5b785b4b-9048-4990-8f6e-8c5c9c85c687.png"

					});

					perfume.HasData(new
					{
						PerfumeId = 2,
						PerfumeName = "Tanzor",
						BrandId = 2,
						Price = 12000m,
						PhotoPath = "5f0acc2c-0d2d-4a3a-adb3-62a61eeb26dc.png"

					});

					perfume.HasData(new
					{
						PerfumeId = 3,
						PerfumeName = "Yievh",
						BrandId = 3,
						Price = 9999.99m,
						PhotoPath = "7c136fde-1bf1-4fa4-b3de-1f0ae837e73b.png"

					});

					perfume.HasData(new
					{
						PerfumeId = 4,
						PerfumeName = "Gloranze",
						BrandId = 4,
						Price = 17000.90m,
						PhotoPath = "41bd99a6-3bcc-495c-b60f-5e7eb373057c.png"

					});

					perfume.HasData(new
					{
						PerfumeId = 5,
						PerfumeName = "Tatillo",
						BrandId = 5,
						Price = 11405m,
						PhotoPath = "88bdad0b-8ff0-409d-ac91-9e9c28bf56e6.jpeg"

					});

					perfume.HasData(new
					{
						PerfumeId = 6,
						PerfumeName = "Kericanso",
						BrandId = 6,
						Price = 74000m,
						PhotoPath = "6ed57a2c-d78b-45e0-9748-6f2005ae5883.jpg"

					});

					perfume.HasData(new
					{
						PerfumeId = 7,
						PerfumeName = "Merdicano",
						BrandId = 7,
						Price = 19800m,
						PhotoPath = "a68632e8-cf17-4ff8-b862-c52896ee4c0c.jpg"

					});




					perfume.HasData(new
					{
						PerfumeId = 8,
						PerfumeName = "Mercant",
						BrandId = 3,
						Price = 50500m,
						PhotoPath = "a68632e8-cf17-4ff8-b862-c52896ee4c0c.jpg"

					});


					perfume.HasData(new
					{
						PerfumeId = 9,
						PerfumeName = "Jaguar",
						BrandId = 2,
						Price = 15700m,
						PhotoPath = "a68632e8-cf17-4ff8-b862-c52896ee4c0c.jpg"

					});


					perfume.HasData(new
					{
						PerfumeId = 10,
						PerfumeName = "Bargello",
						BrandId = 6,
						Price = 9000m,
						PhotoPath = "a68632e8-cf17-4ff8-b862-c52896ee4c0c.jpg"

					});


					perfume.HasData(new
					{
						PerfumeId = 11,
						PerfumeName = "Lovely",
						BrandId = 1,
						Price = 12999m,
						PhotoPath = "a68632e8-cf17-4ff8-b862-c52896ee4c0c.jpg"

					});


					perfume.HasData(new
					{
						PerfumeId = 12,
						PerfumeName = "Merdicano",
						BrandId = 4,
						Price = 14999m,
						PhotoPath = "a68632e8-cf17-4ff8-b862-c52896ee4c0c.jpg"

					});

				}

				);
		}

	}
}