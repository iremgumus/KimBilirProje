alter Proc [dbo].[MusteriEkle]
@KayýtID int,
@Adý nvarchar(50),
@Soyadý nvarchar(50),
@Sifre nvarchar(50),
@Telefon nvarchar(50),
@Eposta nvarchar(50)
as 
begin
if (@KayýtID =0)
begin
insert into MusteriKayýt
(Adý,Soyadý,Sifre,Telefon,Eposta)
values(@Adý,@Soyadý,@Sifre,@Telefon,@Eposta)
End
End


alter proc [dbo].[MusteriGris]
@Adý nvarchar(50),
@Soyadý nvarchar(50),
@Sifre nvarchar(50)
as begin
select * from UcretliMusteriKayýt
where ( Adý=@Adý and Soyadý=@Soyadý and Sifre=@Sifre ) 
end
