alter Proc [dbo].[MusteriEkle]
@Kay�tID int,
@Ad� nvarchar(50),
@Soyad� nvarchar(50),
@Sifre nvarchar(50),
@Telefon nvarchar(50),
@Eposta nvarchar(50)
as 
begin
if (@Kay�tID =0)
begin
insert into MusteriKay�t
(Ad�,Soyad�,Sifre,Telefon,Eposta)
values(@Ad�,@Soyad�,@Sifre,@Telefon,@Eposta)
End
End


alter proc [dbo].[MusteriGris]
@Ad� nvarchar(50),
@Soyad� nvarchar(50),
@Sifre nvarchar(50)
as begin
select * from UcretliMusteriKay�t
where ( Ad�=@Ad� and Soyad�=@Soyad� and Sifre=@Sifre ) 
end
