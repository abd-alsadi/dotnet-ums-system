use KmnlkDB;
------------------------ settings ------------------------
go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addSettings' and s.name='UMS')
begin
exec('create procedure UMS.addSettings (@fldname varchar(250),@fldvalue varchar(max),@fldnote varchar(max),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.settings (fldname,fldvalue,fldnote,fldflags,fldcreated,fldupdated) values (@fldname,@fldvalue,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addSettings (@fldname varchar(250),@fldvalue varchar(max),@fldnote varchar(max),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.settings (fldname,fldvalue,fldnote,fldflags,fldcreated,fldupdated) values (@fldname,@fldvalue,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editSettings' and s.name='UMS')
begin
exec('create procedure UMS.editSettings (@flduid uniqueidentifier,@fldname varchar(250),@fldvalue varchar(max),@fldnote varchar(max),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.settings set fldname=@fldname,fldvalue=@fldvalue,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editSettings (@flduid uniqueidentifier,@fldname varchar(250),@fldvalue varchar(max),@fldnote varchar(max),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	update UMS.settings set fldname=@fldname,fldvalue=@fldvalue,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteSettings' and s.name='UMS')
begin
exec('create procedure UMS.deleteSettings (@flduid uniqueidentifier)
as
begin
	delete from UMS.settings where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteSettings (@flduid uniqueidentifier)
as
begin
	delete from UMS.settings where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getSettingsById' and s.name='UMS')
begin
exec('create procedure UMS.getSettingsById (@flduid uniqueidentifier)
as
begin
	select * from UMS.settings where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getSettingsById (@flduid uniqueidentifier)
as
begin
	select * from UMS.settings where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllSettings' and s.name='UMS')
begin
exec('create procedure UMS.getAllSettings
as
begin
	select * from UMS.settings
end;')
end
else
begin
exec('alter procedure UMS.getAllSettings
as
begin
	select * from UMS.settings
end;')
end

------------------------ users ------------------------

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addUser' and s.name='UMS')
begin
exec('create procedure UMS.addUser (@flddefaultpositionuid uniqueidentifier,@fldname varchar(50),@fldpassword varchar(255),@flddigitalsignatureimage varbinary(max),@fldnote varchar(max),@fldflags bigint,@fldblocked bit,@fldlastlogin varchar(14),@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.users (flddefaultpositionuid,fldname,fldpassword,flddigitalsignatureimage,fldnote,fldflags,fldblocked,fldlastlogin,fldcreated,fldupdated) values (@flddefaultpositionuid,@fldname,@fldpassword,@flddigitalsignatureimage,@fldnote,@fldflags,@fldblocked,@fldlastlogin,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addUser (@flddefaultpositionuid uniqueidentifier,@fldname varchar(50),@fldpassword varchar(255),@flddigitalsignatureimage varbinary(max),@fldnote varchar(max),@fldflags bigint,@fldblocked bit,@fldlastlogin varchar(14),@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.users (flddefaultpositionuid,fldname,fldpassword,flddigitalsignatureimage,fldnote,fldflags,fldblocked,fldlastlogin,fldcreated,fldupdated) values (@flddefaultpositionuid,@fldname,@fldpassword,@flddigitalsignatureimage,@fldnote,@fldflags,@fldblocked,@fldlastlogin,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editUser' and s.name='UMS')
begin
exec('create procedure UMS.editUser (@flduid uniqueidentifier,@flddefaultpositionuid uniqueidentifier,@fldname varchar(50),@fldpassword varchar(255),@flddigitalsignatureimage varbinary(max),@fldnote varchar(max),@fldflags bigint,@fldblocked bit,@fldlastlogin varchar(14),@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	update UMS.users set flddefaultpositionuid=@flddefaultpositionuid,fldname=@fldname,fldpassword=@fldpassword,flddigitalsignatureimage=@flddigitalsignatureimage,fldnote=@fldnote,fldflags=@fldflags,fldblocked=@fldblocked,fldlastlogin=@fldlastlogin,fldcreated=@fldcreated,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editUser (@flduid uniqueidentifier,@flddefaultpositionuid uniqueidentifier,@fldname varchar(50),@fldpassword varchar(255),@flddigitalsignatureimage varbinary(max),@fldnote varchar(max),@fldflags bigint,@fldblocked bit,@fldlastlogin varchar(14),@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	update UMS.users set flddefaultpositionuid=@flddefaultpositionuid,fldname=@fldname,fldpassword=@fldpassword,flddigitalsignatureimage=@flddigitalsignatureimage,fldnote=@fldnote,fldflags=@fldflags,fldblocked=@fldblocked,fldlastlogin=@fldlastlogin,fldcreated=@fldcreated,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteUser' and s.name='UMS')
begin
exec('create procedure UMS.deleteUser (@flduid uniqueidentifier)
as
begin
	delete from UMS.users where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteUser (@flduid uniqueidentifier)
as
begin
	delete from UMS.users where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getUserById' and s.name='UMS')
begin
exec('create procedure UMS.getUserById (@flduid uniqueidentifier)
as
begin
	select * from UMS.users where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getUserById (@flduid uniqueidentifier)
as
begin
	select * from UMS.users where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllUsers' and s.name='UMS')
begin
exec('create procedure UMS.getAllUsers
as
begin
	select * from UMS.users
end;')
end
else
begin
exec('alter procedure UMS.getAllUsers
as
begin
	select * from UMS.users
end;')
end

go

------------------------ delegations ------------------------
go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='adddelegation' and s.name='UMS')
begin
exec('create procedure UMS.adddelegation (@fldfromuseruid uniqueidentifier,@fldtouseruid uniqueidentifier,@fldfromdate varchar(14),@fldtodate varchar(14) ,@fldfromtime varchar(5) ,@fldtotime varchar(5),@fldisactive bit,@fldflags bigint,@fldnote varchar(max),@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.delegations (fldfromuseruid,fldtouseruid,fldfromdate,fldtodate,fldfromtime,fldtotime,fldisactive,fldflags,fldnote,fldcreated,fldupdated) values (@fldfromuseruid,@fldtouseruid,@fldfromdate,@fldtodate,@fldfromtime,@fldtotime,@fldisactive,@fldflags,@fldnote,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.adddelegation (@fldfromuseruid uniqueidentifier,@fldtouseruid uniqueidentifier,@fldfromdate varchar(14),@fldtodate varchar(14) ,@fldfromtime varchar(5) ,@fldtotime varchar(5),@fldisactive bit,@fldflags bigint,@fldnote varchar(max),@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.delegations (fldfromuseruid,fldtouseruid,fldfromdate,fldtodate,fldfromtime,fldtotime,fldisactive,fldflags,fldnote,fldcreated,fldupdated) values (@fldfromuseruid,@fldtouseruid,@fldfromdate,@fldtodate,@fldfromtime,@fldtotime,@fldisactive,@fldflags,@fldnote,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editdelegation' and s.name='UMS')
begin
exec('create procedure UMS.editdelegation (@flduid uniqueidentifier,@fldfromuseruid uniqueidentifier,@fldtouseruid uniqueidentifier,@fldfromdate varchar(14),@fldtodate varchar(14) ,@fldfromtime varchar(5) ,@fldtotime varchar(5),@fldisactive bit,@fldflags bigint,@fldnote varchar(max),@fldupdated varchar(14))
as
begin
	update UMS.delegations set fldfromuseruid=@fldfromuseruid,fldtouseruid=@fldtouseruid,fldfromdate=@fldfromdate,fldtodate=@fldtodate,fldfromtime=@fldfromtime,fldtotime=@fldtotime,fldisactive=@fldisactive,fldflags=@fldflags,fldnote=@fldnote,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editdelegation (@flduid uniqueidentifier,@fldfromuseruid uniqueidentifier,@fldtouseruid uniqueidentifier,@fldfromdate varchar(14),@fldtodate varchar(14) ,@fldfromtime varchar(5) ,@fldtotime varchar(5),@fldisactive bit,@fldflags bigint,@fldnote varchar(max),@fldupdated varchar(14))
as
begin
	update UMS.delegations set fldfromuseruid=@fldfromuseruid,fldtouseruid=@fldtouseruid,fldfromdate=@fldfromdate,fldtodate=@fldtodate,fldfromtime=@fldfromtime,fldtotime=@fldtotime,fldisactive=@fldisactive,fldflags=@fldflags,fldnote=@fldnote,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deletedelegation' and s.name='UMS')
begin
exec('create procedure UMS.deletedelegation (@flduid uniqueidentifier)
as
begin
	delete from UMS.delegations where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deletedelegation (@flduid uniqueidentifier)
as
begin
	delete from UMS.delegations where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdelegationById' and s.name='UMS')
begin
exec('create procedure UMS.getdelegationById (@flduid uniqueidentifier)
as
begin
	select * from UMS.delegations where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdelegationById (@flduid uniqueidentifier)
as
begin
	select * from UMS.delegations where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldelegations' and s.name='UMS')
begin
exec('create procedure UMS.getAlldelegations
as
begin
	select * from UMS.delegations
end;')
end
else
begin
exec('alter procedure UMS.getAlldelegations
as
begin
	select * from UMS.delegations
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdelegationByfromuserid' and s.name='UMS')
begin
exec('create procedure UMS.getdelegationByfromuserid (@fldfromuseruid uniqueidentifier)
as
begin
	select * from UMS.delegations where fldfromuseruid=@fldfromuseruid
end;')
end
else
begin
exec('alter procedure UMS.getdelegationByfromuserid (@fldfromuseruid uniqueidentifier)
as
begin
	select * from UMS.delegations where fldfromuseruid=@fldfromuseruid
end;')
end


if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdelegationBytouserid' and s.name='UMS')
begin
exec('create procedure UMS.getdelegationBytouserid (@fldtouseruid uniqueidentifier)
as
begin
	select * from UMS.delegations where fldtouseruid=@fldtouseruid
end;')
end
else
begin
exec('alter procedure UMS.getdelegationBytouserid (@fldtouseruid uniqueidentifier)
as
begin
	select * from UMS.delegations where fldtouseruid=@fldtouseruid
end;')
end

go
------------------------ profiles ------------------------
go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addprofile' and s.name='UMS')
begin
exec('create procedure UMS.addprofile (
@flduseruid uniqueidentifier,
@fldefirstname varchar(50) ,
@fldefamilyname varchar(50) ,
@fldelocalfirstname varchar(200) ,
@fldelocalfamilyname varchar(200) ,
@fldetitle varchar(200) ,
@fldelocaltitle varchar(200) ,
@fldenickname varchar(50) ,
@fldedisplayname varchar(250) ,
@fldlfirstname varchar(50) ,
@fldlfamilyname varchar(50) ,
@fldllocalfirstname varchar(200) ,
@fldllocalfamilyname varchar(200) ,
@fldltitle varchar(200) ,
@fldllocaltitle varchar(200) ,
@fldlnickname varchar(50) ,
@fldldisplayname varchar(250) ,
@fldphonenumber varchar(50) ,
@fldemail varchar(50) ,
@fldfax varchar(50) ,
@fldcreated varchar(14) ,
@fldupdated varchar(14) 
)
as
begin
	insert into UMS.profiles (
	flduseruid,
fldefirstname ,
fldefamilyname ,
fldelocalfirstname ,
fldelocalfamilyname ,
fldetitle ,
fldelocaltitle ,
fldenickname  ,
fldedisplayname ,
fldlfirstname  ,
fldlfamilyname,
fldllocalfirstname ,
fldllocalfamilyname ,
fldltitle  ,
fldllocaltitle  ,
fldlnickname,
fldldisplayname ,
fldphonenumber  ,
fldemail  ,
fldfax  ,
fldcreated ,
fldupdated  
	) values (
		@flduseruid,
@fldefirstname ,
@fldefamilyname ,
@fldelocalfirstname ,
@fldelocalfamilyname ,
@fldetitle ,
@fldelocaltitle ,
@fldenickname  ,
@fldedisplayname ,
@fldlfirstname  ,
@fldlfamilyname,
@fldllocalfirstname ,
@fldllocalfamilyname ,
@fldltitle  ,
@fldllocaltitle  ,
@fldlnickname,
@fldldisplayname ,
@fldphonenumber  ,
@fldemail  ,
@fldfax  ,
@fldcreated ,
@fldupdated  
)
end;')
end
else
begin
exec('alter procedure UMS.addprofile (
@flduseruid uniqueidentifier,
@fldefirstname varchar(50) ,
@fldefamilyname varchar(50) ,
@fldelocalfirstname varchar(200) ,
@fldelocalfamilyname varchar(200) ,
@fldetitle varchar(200) ,
@fldelocaltitle varchar(200) ,
@fldenickname varchar(50) ,
@fldedisplayname varchar(250) ,
@fldlfirstname varchar(50) ,
@fldlfamilyname varchar(50) ,
@fldllocalfirstname varchar(200) ,
@fldllocalfamilyname varchar(200) ,
@fldltitle varchar(200) ,
@fldllocaltitle varchar(200) ,
@fldlnickname varchar(50) ,
@fldldisplayname varchar(250) ,
@fldphonenumber varchar(50) ,
@fldemail varchar(50) ,
@fldfax varchar(50) ,
@fldcreated varchar(14) ,
@fldupdated varchar(14) 
)
as
begin
	insert into UMS.profiles (
	flduseruid,
fldefirstname ,
fldefamilyname ,
fldelocalfirstname ,
fldelocalfamilyname ,
fldetitle ,
fldelocaltitle ,
fldenickname  ,
fldedisplayname ,
fldlfirstname  ,
fldlfamilyname,
fldllocalfirstname ,
fldllocalfamilyname ,
fldltitle  ,
fldllocaltitle  ,
fldlnickname,
fldldisplayname ,
fldphonenumber  ,
fldemail  ,
fldfax  ,
fldcreated ,
fldupdated  
	) values (
		@flduseruid,
@fldefirstname ,
@fldefamilyname ,
@fldelocalfirstname ,
@fldelocalfamilyname ,
@fldetitle ,
@fldelocaltitle ,
@fldenickname  ,
@fldedisplayname ,
@fldlfirstname  ,
@fldlfamilyname,
@fldllocalfirstname ,
@fldllocalfamilyname ,
@fldltitle  ,
@fldllocaltitle  ,
@fldlnickname,
@fldldisplayname ,
@fldphonenumber  ,
@fldemail  ,
@fldfax  ,
@fldcreated ,
@fldupdated  
)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editprofile' and s.name='UMS')
begin
exec('create procedure UMS.editprofile (
@flduid uniqueidentifier,
@flduseruid uniqueidentifier,
@fldefirstname varchar(50) ,
@fldefamilyname varchar(50) ,
@fldelocalfirstname varchar(200) ,
@fldelocalfamilyname varchar(200) ,
@fldetitle varchar(200) ,
@fldelocaltitle varchar(200) ,
@fldenickname varchar(50) ,
@fldedisplayname varchar(250) ,
@fldlfirstname varchar(50) ,
@fldlfamilyname varchar(50) ,
@fldllocalfirstname varchar(200) ,
@fldllocalfamilyname varchar(200) ,
@fldltitle varchar(200) ,
@fldllocaltitle varchar(200) ,
@fldlnickname varchar(50) ,
@fldldisplayname varchar(250) ,
@fldphonenumber varchar(50) ,
@fldemail varchar(50) ,
@fldfax varchar(50) ,
@fldupdated varchar(14) 
)
as
begin
	update UMS.profiles set 
		flduseruid=@flduseruid,
fldefirstname=@fldefirstname ,
fldefamilyname =@fldefamilyname,
fldelocalfirstname=@fldelocalfirstname ,
fldelocalfamilyname=@fldelocalfamilyname ,
fldetitle=@fldetitle ,
fldelocaltitle=@fldelocaltitle ,
fldenickname =@fldenickname ,
fldedisplayname= @fldedisplayname,
fldlfirstname= @fldlfirstname ,
fldlfamilyname =@fldlfamilyname,
fldllocalfirstname= @fldllocalfirstname,
fldllocalfamilyname= @fldllocalfamilyname,
fldltitle = @fldltitle,
fldllocaltitle= @fldllocaltitle ,
fldlnickname =@fldlnickname,
fldldisplayname= @fldldisplayname,
fldphonenumber=  @fldphonenumber,
fldemail  =@fldemail,
fldfax = @fldfax,
fldupdated  = @fldupdated
	 where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editprofile (
@flduid uniqueidentifier,
@flduseruid uniqueidentifier,
@fldefirstname varchar(50) ,
@fldefamilyname varchar(50) ,
@fldelocalfirstname varchar(200) ,
@fldelocalfamilyname varchar(200) ,
@fldetitle varchar(200) ,
@fldelocaltitle varchar(200) ,
@fldenickname varchar(50) ,
@fldedisplayname varchar(250) ,
@fldlfirstname varchar(50) ,
@fldlfamilyname varchar(50) ,
@fldllocalfirstname varchar(200) ,
@fldllocalfamilyname varchar(200) ,
@fldltitle varchar(200) ,
@fldllocaltitle varchar(200) ,
@fldlnickname varchar(50) ,
@fldldisplayname varchar(250) ,
@fldphonenumber varchar(50) ,
@fldemail varchar(50) ,
@fldfax varchar(50) ,
@fldupdated varchar(14) 
)
as
begin
	update UMS.profiles set 
		flduseruid=@flduseruid,
fldefirstname=@fldefirstname ,
fldefamilyname =@fldefamilyname,
fldelocalfirstname=@fldelocalfirstname ,
fldelocalfamilyname=@fldelocalfamilyname ,
fldetitle=@fldetitle ,
fldelocaltitle=@fldelocaltitle ,
fldenickname =@fldenickname ,
fldedisplayname= @fldedisplayname,
fldlfirstname= @fldlfirstname ,
fldlfamilyname =@fldlfamilyname,
fldllocalfirstname= @fldllocalfirstname,
fldllocalfamilyname= @fldllocalfamilyname,
fldltitle = @fldltitle,
fldllocaltitle= @fldllocaltitle ,
fldlnickname =@fldlnickname,
fldldisplayname= @fldldisplayname,
fldphonenumber=  @fldphonenumber,
fldemail  =@fldemail,
fldfax = @fldfax,
fldupdated  = @fldupdated
	 where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteprofile' and s.name='UMS')
begin
exec('create procedure UMS.deleteprofile (@flduid uniqueidentifier)
as
begin
	delete from UMS.profiles where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteprofile (@flduid uniqueidentifier)
as
begin
	delete from UMS.profiles where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getprofileById' and s.name='UMS')
begin
exec('create procedure UMS.getprofileById (@flduid uniqueidentifier)
as
begin
	select * from UMS.profiles where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getprofileById (@flduid uniqueidentifier)
as
begin
	select * from UMS.profiles where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllprofiles' and s.name='UMS')
begin
exec('create procedure UMS.getAllprofiles
as
begin
	select * from UMS.profiles
end;')
end
else
begin
exec('alter procedure UMS.getAllprofiles
as
begin
	select * from UMS.profiles
end;')
end

go

------------------------ roles ------------------------

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addRole' and s.name='UMS')
begin
exec('create procedure UMS.addRole (@fldpositionmanager uniqueidentifier,@fldename varchar(255),@fldlname varchar(255),@fldnote varchar(max),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.roles (fldpositionmanager,fldename,fldlname,fldnote,fldflags,fldcreated,fldupdated) values (@fldpositionmanager,@fldename,@fldlname,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addRole (@fldpositionmanager uniqueidentifier,@fldename varchar(255),@fldlname varchar(255),@fldnote varchar(max),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.roles (fldpositionmanager,fldename,fldlname,fldnote,fldflags,fldcreated,fldupdated) values (@fldpositionmanager,@fldename,@fldlname,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editRole' and s.name='UMS')
begin
exec('create procedure UMS.editRole (@flduid uniqueidentifier,@fldpositionmanager uniqueidentifier,@fldename varchar(255),@fldlname varchar(255),@fldnote varchar(max),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.roles set fldpositionmanager=@fldpositionmanager,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editRole (@flduid uniqueidentifier,@fldpositionmanager uniqueidentifier,@fldename varchar(255),@fldlname varchar(255),@fldnote varchar(max),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.roles set fldpositionmanager=@fldpositionmanager,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteRole' and s.name='UMS')
begin
exec('create procedure UMS.deleteRole (@flduid uniqueidentifier)
as
begin
	delete from UMS.roles where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteRole (@flduid uniqueidentifier)
as
begin
	delete from UMS.roles where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getRoleById' and s.name='UMS')
begin
exec('create procedure UMS.getRoleById (@flduid uniqueidentifier)
as
begin
	select * from UMS.roles where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getRoleById (@flduid uniqueidentifier)
as
begin
	select * from UMS.roles where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllRoles' and s.name='UMS')
begin
exec('create procedure UMS.getAllRoles
as
begin
	select * from UMS.roles
end;')
end
else
begin
exec('alter procedure UMS.getAllRoles
as
begin
	select * from UMS.roles
end;')
end


------------------------ departments ------------------------


go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addDepartment' and s.name='UMS')
begin
exec('create procedure UMS.addDepartment (@fldpositionmanager uniqueidentifier,@fldparentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10) ,@fldcode varchar(50),@fldlevel varchar(50),@fldfax varchar(50),@fldparentcode varchar(50) ,@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.departments (fldpositionmanager,fldparentuid,fldename,fldlname,fldgrade,fldcode,fldlevel,fldfax,fldparentcode,fldnote,fldflags,fldcreated,fldupdated) values (@fldpositionmanager,@fldparentuid,@fldename,@fldlname,@fldgrade,@fldcode,@fldlevel,@fldfax,@fldparentcode,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addDepartment (@fldpositionmanager uniqueidentifier,@fldparentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10) ,@fldcode varchar(50),@fldlevel varchar(50),@fldfax varchar(50),@fldparentcode varchar(50) ,@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.departments (fldpositionmanager,fldparentuid,fldename,fldlname,fldgrade,fldcode,fldlevel,fldfax,fldparentcode,fldnote,fldflags,fldcreated,fldupdated) values (@fldpositionmanager,@fldparentuid,@fldename,@fldlname,@fldgrade,@fldcode,@fldlevel,@fldfax,@fldparentcode,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editdepartment' and s.name='UMS')
begin
exec('create procedure UMS.editdepartment (@flduid uniqueidentifier,@fldpositionmanager uniqueidentifier,@fldparentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10) ,@fldcode varchar(50),@fldlevel varchar(50),@fldfax varchar(50),@fldparentcode varchar(50) ,@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.departments set fldpositionmanager=@fldpositionmanager,fldparentuid=@fldparentuid,fldename=@fldename,fldlname=@fldlname,fldgrade=@fldgrade,fldcode=@fldcode,fldlevel=@fldlevel,fldfax=@fldfax,fldparentcode=@fldparentcode,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editdepartment (@flduid uniqueidentifier,@fldpositionmanager uniqueidentifier,@fldparentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10) ,@fldcode varchar(50),@fldlevel varchar(50),@fldfax varchar(50),@fldparentcode varchar(50) ,@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.departments set fldpositionmanager=@fldpositionmanager,fldparentuid=@fldparentuid,fldename=@fldename,fldlname=@fldlname,fldgrade=@fldgrade,fldcode=@fldcode,fldlevel=@fldlevel,fldfax=@fldfax,fldparentcode=@fldparentcode,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deletedepartment' and s.name='UMS')
begin
exec('create procedure UMS.deletedepartment (@flduid uniqueidentifier)
as
begin
	delete from UMS.departments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deletedepartment (@flduid uniqueidentifier)
as
begin
	delete from UMS.departments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentById' and s.name='UMS')
begin
exec('create procedure UMS.getdepartmentById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldepartments' and s.name='UMS')
begin
exec('create procedure UMS.getAlldepartments
as
begin
	select * from UMS.departments
end;')
end
else
begin
exec('alter procedure UMS.getAlldepartments
as
begin
	select * from UMS.departments
end;')
end

------------------------ operations ------------------------

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addoperation' and s.name='UMS')
begin
exec('create procedure UMS.addoperation (@fldename varchar(250),@fldlname varchar(250),@fldoperationnumber decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.operations (fldename,fldlname,fldoperationnumber,fldnote,fldflags,fldcreated,fldupdated) values (@fldename,@fldlname,@fldoperationnumber,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addoperation (@fldename varchar(250),@fldlname varchar(250),@fldoperationnumber decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.operations (fldename,fldlname,fldoperationnumber,fldnote,fldflags,fldcreated,fldupdated) values (@fldename,@fldlname,@fldoperationnumber,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editoperation' and s.name='UMS')
begin
exec('create procedure UMS.editoperation (@flduid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldoperationnumber decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.operations set fldename=@fldename,fldlname=@fldlname,fldoperationnumber=@fldoperationnumber,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editoperation (@flduid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldoperationnumber decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.operations set fldename=@fldename,fldlname=@fldlname,fldoperationnumber=@fldoperationnumber,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteoperation' and s.name='UMS')
begin
exec('create procedure UMS.deleteoperation (@flduid uniqueidentifier)
as
begin
	delete from UMS.operations where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteoperation (@flduid uniqueidentifier)
as
begin
	delete from UMS.operations where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getoperationById' and s.name='UMS')
begin
exec('create procedure UMS.getoperationById (@flduid uniqueidentifier)
as
begin
	select * from UMS.operations where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getoperationById (@flduid uniqueidentifier)
as
begin
	select * from UMS.operations where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlloperations' and s.name='UMS')
begin
exec('create procedure UMS.getAlloperations
as
begin
	select * from UMS.operations
end;')
end
else
begin
exec('alter procedure UMS.getAlloperations
as
begin
	select * from UMS.operations
end;')
end

------------------------ privilages ------------------------

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addprivilage' and s.name='UMS')
begin
exec('create procedure UMS.addprivilage (@fldename varchar(250),@fldlname varchar(250),@fldprivilagenumber decimal(38,0),@fldtype decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.privilages (fldename,fldlname,fldprivilagenumber,fldtype,fldnote,fldflags,fldcreated,fldupdated) values (@fldename,@fldlname,@fldprivilagenumber,@fldtype,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addprivilage (@fldename varchar(250),@fldlname varchar(250),@fldprivilagenumber decimal(38,0),@fldtype decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.privilages (fldename,fldlname,fldprivilagenumber,fldtype,fldnote,fldflags,fldcreated,fldupdated) values (@fldename,@fldlname,@fldprivilagenumber,@fldtype,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editprivilage' and s.name='UMS')
begin
exec('create procedure UMS.editprivilage (@flduid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldprivilagenumber decimal(38,0),@fldtype decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.privilages set fldename=@fldename,fldlname=@fldlname,fldprivilagenumber=@fldprivilagenumber,fldtype=@fldtype,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editprivilage (@flduid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldprivilagenumber decimal(38,0),@fldtype decimal(38,0),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.privilages set fldename=@fldename,fldlname=@fldlname,fldprivilagenumber=@fldprivilagenumber,fldtype=@fldtype,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteprivilage' and s.name='UMS')
begin
exec('create procedure UMS.deleteprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.privilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.privilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getprivilageById' and s.name='UMS')
begin
exec('create procedure UMS.getprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.privilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.privilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllprivilages' and s.name='UMS')
begin
exec('create procedure UMS.getAllprivilages
as
begin
	select * from UMS.privilages
end;')
end
else
begin
exec('alter procedure UMS.getAllprivilages
as
begin
	select * from UMS.privilages
end;')
end

------------------------ positions ------------------------
go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='addposition' and s.name='UMS')
begin
exec('create procedure UMS.addposition (@fldusermanager uniqueidentifier,@fldname varchar(250),@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.positions (fldusermanager,fldname,fldename,fldlname,fldgrade,fldnote,fldflags,fldcreated,fldupdated) values (@fldusermanager,@fldname,@fldename,@fldlname,@fldgrade,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.addposition (@fldusermanager uniqueidentifier,@fldname varchar(250),@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.positions (fldusermanager,fldname,fldename,fldlname,fldgrade,fldnote,fldflags,fldcreated,fldupdated) values (@fldusermanager,@fldname,@fldename,@fldlname,@fldgrade,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='editposition' and s.name='UMS')
begin
exec('create procedure UMS.editposition (@flduid uniqueidentifier,@fldusermanager uniqueidentifier,@fldname varchar(250),@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.positions set fldusermanager=@fldusermanager,fldname=@fldname,fldename=@fldename,fldlname=@fldlname,fldgrade=@fldgrade,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.editposition (@flduid uniqueidentifier,@fldusermanager uniqueidentifier,@fldname varchar(250),@fldename varchar(250),@fldlname varchar(250),@fldgrade varchar(10),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.positions set fldusermanager=@fldusermanager,fldname=@fldname,fldename=@fldename,fldlname=@fldlname,fldgrade=@fldgrade,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='deleteposition' and s.name='UMS')
begin
exec('create procedure UMS.deleteposition (@flduid uniqueidentifier)
as
begin
	delete from UMS.positions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.deleteposition (@flduid uniqueidentifier)
as
begin
	delete from UMS.positions where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpositionById' and s.name='UMS')
begin
exec('create procedure UMS.getpositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getpositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positions where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllpositions' and s.name='UMS')
begin
exec('create procedure UMS.getAllpositions
as
begin
	select * from UMS.positions
end;')
end
else
begin
exec('alter procedure UMS.getAllpositions
as
begin
	select * from UMS.positions
end;')
end
------------------------ roles positions ------------------------

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='AddRolePosition' and s.name='UMS')
begin
exec('create procedure UMS.AddRolePosition (@fldpositionuid uniqueidentifier,@fldroleuid uniqueidentifier,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14),@flddeleted bit  )
as
begin
	insert into UMS.rolespositions (fldpositionuid,fldroleuid,fldflags,fldcreated,fldupdated,flddeleted) values (@fldpositionuid,@fldroleuid,@fldflags,@fldcreated,@fldupdated,@flddeleted) 
end;')
end
else
begin
exec('alter procedure UMS.AddRolePosition (@fldpositionuid uniqueidentifier,@fldroleuid uniqueidentifier,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14),@flddeleted bit  )
as
begin
	insert into UMS.rolespositions (fldpositionuid,fldroleuid,fldflags,fldcreated,fldupdated,flddeleted) values (@fldpositionuid,@fldroleuid,@fldflags,@fldcreated,@fldupdated,@flddeleted) 
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EditRolePosition' and s.name='UMS')
begin
exec('create procedure UMS.EditRolePosition (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@fldroleuid uniqueidentifier,@fldflags bigint,@fldupdated varchar(14),@flddeleted bit  )
as
begin
	update UMS.rolespositions set fldpositionuid=@fldpositionuid,fldroleuid=@fldroleuid,fldflags=@fldflags,fldupdated=@fldupdated,flddeleted=@flddeleted where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.EditRolePosition (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@fldroleuid uniqueidentifier,@fldflags bigint,@fldupdated varchar(14),@flddeleted bit  )
as
begin
	update UMS.rolespositions set fldpositionuid=@fldpositionuid,fldroleuid=@fldroleuid,fldflags=@fldflags,fldupdated=@fldupdated,flddeleted=@flddeleted where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='DeleteRolePosition' and s.name='UMS')
begin
exec('create procedure UMS.DeleteRolePosition (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolespositions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.DeleteRolePosition (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolespositions where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getRolePositionById' and s.name='UMS')
begin
exec('create procedure UMS.getRolePositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolespositions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getRolePositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolespositions where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllRolesPositions' and s.name='UMS')
begin
exec('create procedure UMS.getAllRolesPositions(@isDeleted bit)
as
begin
	select * from UMS.rolespositions where flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getAllRolesPositions(@isDeleted bit)
as
begin
	select * from UMS.rolespositions where flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getRolesByPositionId' and s.name='UMS')
begin
exec('create procedure UMS.getRolesByPositionId(@fldpositionid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.rolespositions where fldpositionuid=@fldpositionid and flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getRolesByPositionId(@fldpositionid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.rolespositions where fldpositionuid=@fldpositionid and flddeleted=@isDeleted
end;')
end


if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getPositionsByRoleId' and s.name='UMS')
begin
exec('create procedure UMS.getPositionsByRoleId(@fldroleid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.rolespositions where fldroleuid=@fldroleid and flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getPositionsByRoleId(@fldroleid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.rolespositions where fldroleuid=@fldroleid and flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getRolePositionByPositionidANDRoleId' and s.name='UMS')
begin
exec('create procedure UMS.getRolePositionByPositionidANDRoleId(@fldroleid uniqueidentifier,@fldpositionid uniqueidentifier)
as
begin
	select * from UMS.rolespositions where fldroleuid=@fldroleid and fldpositionuid=@fldpositionid
end;')
end
else
begin
exec('alter procedure UMS.getRolePositionByPositionidANDRoleId(@fldroleid uniqueidentifier,@fldpositionid uniqueidentifier)
as
begin
	select * from UMS.rolespositions where fldroleuid=@fldroleid and fldpositionuid=@fldpositionid
end;')
end

------------------------ departments positions ------------------------

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='AddDepartmentPosition' and s.name='UMS')
begin
exec('create procedure UMS.AddDepartmentPosition (@fldpositionuid uniqueidentifier,@flddepartmentuid uniqueidentifier,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14) ,@flddeleted bit)
as
begin
	insert into UMS.departmentspositions (fldpositionuid,flddepartmentuid,fldflags,fldcreated,fldupdated,flddeleted) values (@fldpositionuid,@flddepartmentuid,@fldflags,@fldcreated,@fldupdated,@flddeleted) 
end;')
end
else
begin
exec('alter procedure UMS.AdddepartmentPosition (@fldpositionuid uniqueidentifier,@flddepartmentuid uniqueidentifier,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14),@flddeleted bit )
as
begin
	insert into UMS.departmentspositions (fldpositionuid,flddepartmentuid,fldflags,fldcreated,fldupdated,flddeleted) values (@fldpositionuid,@flddepartmentuid,@fldflags,@fldcreated,@fldupdated,@flddeleted) 
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EditdepartmentPosition' and s.name='UMS')
begin
exec('create procedure UMS.EditdepartmentPosition (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@flddepartmentuid uniqueidentifier,@fldflags bigint,@fldupdated varchar(14),@flddeleted bit )
as
begin
	update UMS.departmentspositions set fldpositionuid=@fldpositionuid,flddepartmentuid=@flddepartmentuid,fldflags=@fldflags,fldupdated=@fldupdated,flddeleted=@flddeleted where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.EditdepartmentPosition (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@flddepartmentuid uniqueidentifier,@fldflags bigint,@fldupdated varchar(14),@flddeleted bit )
as
begin
	update UMS.departmentspositions set fldpositionuid=@fldpositionuid,flddepartmentuid=@flddepartmentuid,fldflags=@fldflags,fldupdated=@fldupdated,flddeleted=@flddeleted where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='DeletedepartmentPosition' and s.name='UMS')
begin
exec('create procedure UMS.DeletedepartmentPosition (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentspositions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.DeletedepartmentPosition (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentspositions where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentPositionById' and s.name='UMS')
begin
exec('create procedure UMS.getdepartmentPositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentspositions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentPositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentspositions where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldepartmentsPositions' and s.name='UMS')
begin
exec('create procedure UMS.getAlldepartmentsPositions(@isDeleted bit)
as
begin
	select * from UMS.departmentspositions where flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getAlldepartmentsPositions(@isDeleted bit)
as
begin
	select * from UMS.departmentspositions where flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentsByPositionId' and s.name='UMS')
begin
exec('create procedure UMS.getdepartmentsByPositionId(@fldpositionid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.departmentspositions where fldpositionuid=@fldpositionid and flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentsByPositionId(@fldpositionid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.departmentspositions where fldpositionuid=@fldpositionid and flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getPositionsBydepartmentId' and s.name='UMS')
begin
exec('create procedure UMS.getPositionsBydepartmentId(@flddepartmentid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.departmentspositions where flddepartmentuid=@flddepartmentid and flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getPositionsBydepartmentId(@flddepartmentid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.departmentspositions where flddepartmentuid=@flddepartmentid and flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentPositionByPositionidANDdepartmentId' and s.name='UMS')
begin
exec('create procedure UMS.getdepartmentPositionByPositionidANDdepartmentId(@flddepartmentid uniqueidentifier,@fldpositionid uniqueidentifier)
as
begin
	select * from UMS.departmentspositions where flddepartmentuid=@flddepartmentid and fldpositionuid=@fldpositionid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentPositionByPositionidANDdepartmentId(@flddepartmentid uniqueidentifier,@fldpositionid uniqueidentifier)
as
begin
	select * from UMS.departmentspositions where flddepartmentuid=@flddepartmentid and fldpositionuid=@fldpositionid
end;')
end

------------------------ users positions ------------------------
go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='AdduserPosition' and s.name='UMS')
begin
exec('create procedure UMS.AdduserPosition (@fldpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14),@flddeleted bit )
as
begin
	insert into UMS.userspositions (fldpositionuid,flduseruid,fldflags,fldcreated,fldupdated,flddeleted) values (@fldpositionuid,@flduseruid,@fldflags,@fldcreated,@fldupdated,@flddeleted) 
end;')
end
else
begin
exec('alter procedure UMS.AdduserPosition (@fldpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14),@flddeleted bit )
as
begin
	insert into UMS.userspositions (fldpositionuid,flduseruid,fldflags,fldcreated,fldupdated,flddeleted) values (@fldpositionuid,@flduseruid,@fldflags,@fldcreated,@fldupdated,@flddeleted) 
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EdituserPosition' and s.name='UMS')
begin
exec('create procedure UMS.EdituserPosition (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldflags bigint,@fldupdated varchar(14),@flddeleted bit )
as
begin
	update UMS.userspositions set fldpositionuid=@fldpositionuid,flduseruid=@flduseruid,fldflags=@fldflags,fldupdated=@fldupdated,flddeleted=@flddeleted where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.EdituserPosition (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldflags bigint,@fldupdated varchar(14),@flddeleted bit  )
as
begin
	update UMS.userspositions set fldpositionuid=@fldpositionuid,flduseruid=@flduseruid,fldflags=@fldflags,fldupdated=@fldupdated,flddeleted=@flddeleted where flduid=@flduid
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='DeleteuserPosition' and s.name='UMS')
begin
exec('create procedure UMS.DeleteuserPosition (@flduid uniqueidentifier)
as
begin
	delete from UMS.userspositions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.DeleteuserPosition (@flduid uniqueidentifier)
as
begin
	delete from UMS.userspositions where flduid=@flduid
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserPositionById' and s.name='UMS')
begin
exec('create procedure UMS.getuserPositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.userspositions where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getuserPositionById (@flduid uniqueidentifier)
as
begin
	select * from UMS.userspositions where flduid=@flduid
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllusersPositions' and s.name='UMS')
begin
exec('create procedure UMS.getAllusersPositions(@isDeleted bit)
as
begin
	select * from UMS.userspositions where flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getAllusersPositions(@isDeleted bit)
as
begin
	select * from UMS.userspositions where flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getusersByPositionId' and s.name='UMS')
begin
exec('create procedure UMS.getusersByPositionId(@fldpositionid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.userspositions where fldpositionuid=@fldpositionid and flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getusersByPositionId(@fldpositionid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.userspositions where fldpositionuid=@fldpositionid and flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getPositionsByuserId' and s.name='UMS')
begin
exec('create procedure UMS.getPositionsByuserId(@flduserid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.userspositions where flduseruid=@flduserid and flddeleted=@isDeleted
end;')
end
else
begin
exec('alter procedure UMS.getPositionsByuserId(@flduserid uniqueidentifier,@isDeleted bit)
as
begin
	select * from UMS.userspositions where flduseruid=@flduserid and flddeleted=@isDeleted
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserPositionByPositionidANDuserId' and s.name='UMS')
begin
exec('create procedure UMS.getuserPositionByPositionidANDuserId(@flduserid uniqueidentifier,@fldpositionid uniqueidentifier)
as
begin
	select * from UMS.userspositions where flduseruid=@flduserid and fldpositionuid=@fldpositionid
end;')
end
else
begin
exec('alter procedure UMS.getuserPositionByPositionidANDuserId(@flduserid uniqueidentifier,@fldpositionid uniqueidentifier)
as
begin
	select * from UMS.userspositions where flduseruid=@flduserid and fldpositionuid=@fldpositionid
end;')
end

go

-------------------- users notes -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='AdduserNote' and s.name='UMS')
begin
exec('create procedure UMS.AdduserNote (@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.usersnotes (flduseruid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@flduseruid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.AdduserNote (@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.usersnotes (flduseruid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@flduseruid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EdituserNote' and s.name='UMS')
begin
exec('create procedure UMS.EdituserNote (@flduid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.usersnotes set flduseruid=@flduseruid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.EdituserNote (@flduid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.usersnotes set flduseruid=@flduseruid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='DeleteuserNote' and s.name='UMS')
begin
exec('create procedure UMS.DeleteuserNote (@flduid uniqueidentifier)
as
begin
	delete from UMS.usersnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.DeleteuserNote (@flduid uniqueidentifier)
as
begin
	delete from UMS.usersnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserNoteById' and s.name='UMS')
begin
exec('create procedure UMS.getuserNoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.usersnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getuserNoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.usersnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllusersNotes' and s.name='UMS')
begin
exec('create procedure UMS.getAllusersNotes
as
begin
	select * from UMS.usersnotes
end;')
end
else
begin
exec('alter procedure UMS.getAllusersNotes
as
begin
	select * from UMS.usersnotes
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getusersnotesByuserId' and s.name='UMS')
begin
exec('create procedure UMS.getusersnotesByuserId(@flduserid uniqueidentifier)
as
begin
	select * from UMS.usersnotes where flduseruid=@flduserid
end;')
end
else
begin
exec('alter procedure UMS.getusersnotesByuserId(@flduserid uniqueidentifier)
as
begin
	select * from UMS.usersnotes where flduseruid=@flduserid
end;')
end

go

-------------------- users positions notes -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Adduserpositionnote' and s.name='UMS')
begin
exec('create procedure UMS.Adduserpositionnote (@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.userspositionsnotes (flduserpositionuid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@flduserpositionuid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Adduserpositionnote (@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.userspositionsnotes (flduserpositionuid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@flduserpositionuid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EdituserPositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Edituserpositionnote (@flduid uniqueidentifier,@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.userspositionsnotes set flduserpositionuid=@flduserpositionuid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Edituserpositionnote (@flduid uniqueidentifier,@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.userspositionsnotes set flduserpositionuid=@flduserpositionuid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleteuserpositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Deleteuserpositionnote (@flduid uniqueidentifier)
as
begin
	delete from UMS.userspositionsnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleteuserpositionnote (@flduid uniqueidentifier)
as
begin
	delete from UMS.userspositionsnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserpositionnoteById' and s.name='UMS')

begin
exec('create procedure UMS.getuserpositionnoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.userspositionsnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getuserpositionnoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.userspositionsnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlluserspositionsnotes' and s.name='UMS')

begin
exec('create procedure UMS.getAlluserspositionsnotes
as
begin
	select * from UMS.userspositionsnotes
end;')
end
else
begin
exec('alter procedure UMS.getAlluserspositionsnotes
as
begin
	select * from UMS.userspositionsnotes
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserspositionsnotesByuserpositionId' and s.name='UMS')

begin
exec('create procedure UMS.getuserspositionsnotesByuserpositionId(@flduserpositionid uniqueidentifier)
as
begin
	select * from UMS.userspositionsnotes where flduserpositionuid=@flduserpositionid
end;')
end
else
begin
exec('alter procedure UMS.getuserspositionsnotesByuserpositionId(@flduserpositionid uniqueidentifier)
as
begin
	select * from UMS.userspositionsnotes where flduserpositionuid=@flduserpositionid
end;')
end

go



-------------------- departments positions notes -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Adddepartmentpositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Adddepartmentpositionnote (@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.departmentspositionsnotes (flddepartmentpositionuid,flduseruid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@flddepartmentpositionuid,@flduseruid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Adddepartmentpositionnote (@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.departmentspositionsnotes (flddepartmentpositionuid,flduseruid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@flddepartmentpositionuid,@flduseruid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editdepartmentpositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Editdepartmentpositionnote (@flduid uniqueidentifier,@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.departmentspositionsnotes set flddepartmentpositionuid=@flddepartmentpositionuid,flduseruid=@flduseruid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editdepartmentpositionnote (@flduid uniqueidentifier,@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.departmentspositionsnotes set flddepartmentpositionuid=@flddepartmentpositionuid,flduseruid=@flduseruid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletedepartmentpositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Deletedepartmentpositionnote (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentspositionsnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletedepartmentpositionnote (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentspositionsnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentpositionnoteById' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentpositionnoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentpositionnoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldepartmentspositionsnotes' and s.name='UMS')

begin
exec('create procedure UMS.getAlldepartmentspositionsnotes
as
begin
	select * from UMS.departmentspositionsnotes
end;')
end
else
begin
exec('alter procedure UMS.getAlldepartmentspositionsnotes
as
begin
	select * from UMS.departmentspositionsnotes
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentspositionsnotesBydepartmentpositionId' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentspositionsnotesBydepartmentpositionId(@flddepartmentpositionuid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsnotes where flddepartmentpositionuid=@flddepartmentpositionuid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentspositionsnotesBydepartmentpositionId(@flddepartmentpositionuid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsnotes where flddepartmentpositionuid=@flddepartmentpositionuid
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentspositionsnotesByuserId' and s.name='UMS')
begin
exec('create procedure UMS.getdepartmentspositionsnotesByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsnotes where flduseruid=@flduseruid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentspositionsnotesByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsnotes where flduseruid=@flduseruid
end;')
end

go





-------------------- roles positions notes -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addrolepositionnote' and s.name='UMS')
begin
exec('create procedure UMS.Addrolepositionnote (@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.rolespositionsnotes (fldrolepositionuid,flduseruid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@fldrolepositionuid,@flduseruid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addrolepositionnote (@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14))
as
begin
	insert into UMS.rolespositionsnotes (fldrolepositionuid,flduseruid,fldtype,flddate,fldnote,fldflags,fldcreated,fldupdated) values  (@fldrolepositionuid,@flduseruid,@fldtype,@flddate,@fldnote,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editrolepositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Editrolepositionnote (@flduid uniqueidentifier,@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.rolespositionsnotes set fldrolepositionuid=@fldrolepositionuid,flduseruid=@flduseruid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editrolepositionnote (@flduid uniqueidentifier,@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@flddate varchar(14),@fldnote varchar(max) ,@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.rolespositionsnotes set fldrolepositionuid=@fldrolepositionuid,flduseruid=@flduseruid,fldtype=@fldtype,flddate=@flddate,fldnote=@fldnote,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleterolepositionnote' and s.name='UMS')

begin
exec('create procedure UMS.Deleterolepositionnote (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolespositionsnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleterolepositionnote (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolespositionsnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolepositionnoteById' and s.name='UMS')

begin
exec('create procedure UMS.getrolepositionnoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsnotes where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getrolepositionnoteById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsnotes where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllrolespositionsnotes' and s.name='UMS')

begin
exec('create procedure UMS.getAllrolespositionsnotes
as
begin
	select * from UMS.rolespositionsnotes
end;')
end
else
begin
exec('alter procedure UMS.getAllrolespositionsnotes
as
begin
	select * from UMS.rolespositionsnotes
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolespositionsnotesByrolepositionId' and s.name='UMS')

begin
exec('create procedure UMS.getrolespositionsnotesByrolepositionId(@fldrolepositionuid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsnotes where fldrolepositionuid=@fldrolepositionuid
end;')
end
else
begin
exec('alter procedure UMS.getrolespositionsnotesByrolepositionId(@fldrolepositionuid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsnotes where fldrolepositionuid=@fldrolepositionuid
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolespositionsnotesByuserId' and s.name='UMS')

begin
exec('create procedure UMS.getrolespositionsnotesByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsnotes where flduseruid=@flduseruid
end;')
end
else
begin
exec('alter procedure UMS.getrolespositionsnotesByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsnotes where flduseruid=@flduseruid
end;')
end

go

-------------------- users contacts -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addusercontact' and s.name='UMS')

begin
exec('create procedure UMS.Addusercontact (@flduseruid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit ,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.userscontacts (flduseruid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@flduseruid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addusercontact (@flduseruid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.userscontacts (flduseruid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@flduseruid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editusercontact' and s.name='UMS')

begin
exec('create procedure UMS.Editusercontact (@flduid uniqueidentifier,@flduseruid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.userscontacts set  flduseruid=@flduseruid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editusercontact (@flduid uniqueidentifier,@flduseruid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.userscontacts set  flduseruid=@flduseruid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleteusercontact' and s.name='UMS')

begin
exec('create procedure UMS.Deleteusercontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.userscontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleteusercontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.userscontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getusercontactById' and s.name='UMS')

begin
exec('create procedure UMS.getusercontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.userscontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getusercontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.userscontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlluserscontacts' and s.name='UMS')

begin
exec('create procedure UMS.getAlluserscontacts
as
begin
	select * from UMS.userscontacts
end;')
end
else
begin
exec('alter procedure UMS.getAlluserscontacts
as
begin
	select * from UMS.userscontacts
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserscontactsByuserId' and s.name='UMS')

begin
exec('create procedure UMS.getuserscontactsByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.userscontacts where flduseruid=@flduseruid
end;')
end
else
begin
exec('alter procedure UMS.getuserscontactsByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.userscontacts where flduseruid=@flduseruid
end;')
end

go

-------------------- positions contacts -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addpositioncontact' and s.name='UMS')

begin
exec('create procedure UMS.Addpositioncontact (@fldpositionuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.positionscontacts (fldpositionuid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@fldpositionuid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addpositioncontact (@fldpositionuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.positionscontacts (fldpositionuid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@fldpositionuid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editpositioncontact' and s.name='UMS')

begin
exec('create procedure UMS.Editpositioncontact (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.positionscontacts set  fldpositionuid=@fldpositionuid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editpositioncontact (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.positionscontacts set  fldpositionuid=@fldpositionuid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletepositioncontact' and s.name='UMS')

begin
exec('create procedure UMS.Deletepositioncontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.positionscontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletepositioncontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.positionscontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpositioncontactById' and s.name='UMS')

begin
exec('create procedure UMS.getpositioncontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positionscontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getpositioncontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positionscontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllpositionscontacts' and s.name='UMS')

begin
exec('create procedure UMS.getAllpositionscontacts
as
begin
	select * from UMS.positionscontacts
end;')
end
else
begin
exec('alter procedure UMS.getAllpositionscontacts
as
begin
	select * from UMS.positionscontacts
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpositionscontactsBypositionId' and s.name='UMS')

begin
exec('create procedure UMS.getpositionscontactsBypositionId(@fldpositionuid uniqueidentifier)
as
begin
	select * from UMS.positionscontacts where fldpositionuid=@fldpositionuid
end;')
end
else
begin
exec('alter procedure UMS.getpositionscontactsBypositionId(@fldpositionuid uniqueidentifier)
as
begin
	select * from UMS.positionscontacts where fldpositionuid=@fldpositionuid
end;')
end

go

-------------------- departments contacts -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Adddepartmentcontact' and s.name='UMS')

begin
exec('create procedure UMS.Adddepartmentcontact (@flddepartmentuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.departmentscontacts (flddepartmentuid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@flddepartmentuid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Adddepartmentcontact (@flddepartmentuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.departmentscontacts (flddepartmentuid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@flddepartmentuid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editdepartmentcontact' and s.name='UMS')

begin
exec('create procedure UMS.Editdepartmentcontact (@flduid uniqueidentifier,@flddepartmentuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.departmentscontacts set  flddepartmentuid=@flddepartmentuid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editdepartmentcontact (@flduid uniqueidentifier,@flddepartmentuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.departmentscontacts set  flddepartmentuid=@flddepartmentuid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletedepartmentcontact' and s.name='UMS')

begin
exec('create procedure UMS.Deletedepartmentcontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentscontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletedepartmentcontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentscontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentcontactById' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentcontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentscontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentcontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentscontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldepartmentscontacts' and s.name='UMS')

begin
exec('create procedure UMS.getAlldepartmentscontacts
as
begin
	select * from UMS.departmentscontacts
end;')
end
else
begin
exec('alter procedure UMS.getAlldepartmentscontacts
as
begin
	select * from UMS.departmentscontacts
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentscontactsBydepartmentId' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentscontactsBydepartmentId(@flddepartmentuid uniqueidentifier)
as
begin
	select * from UMS.departmentscontacts where flddepartmentuid=@flddepartmentuid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentscontactsBydepartmentId(@flddepartmentuid uniqueidentifier)
as
begin
	select * from UMS.departmentscontacts where flddepartmentuid=@flddepartmentuid
end;')
end

go



-------------------- roles contacts -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addrolecontact' and s.name='UMS')

begin
exec('create procedure UMS.Addrolecontact (@fldroleuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.rolescontacts (fldroleuid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@fldroleuid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addrolecontact (@fldroleuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.rolescontacts (fldroleuid,fldtype,fldname,fldemail,fldphonenumber,fldfax,fldnote,fldstatus,fldflags,fldcreated,fldupdated) values  (@fldroleuid,@fldtype,@fldname,@fldemail,@fldphonenumber,@fldfax,@fldnote,@fldstatus,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editrolecontact' and s.name='UMS')

begin
exec('create procedure UMS.Editrolecontact (@flduid uniqueidentifier,@fldroleuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.rolescontacts set  fldroleuid=@fldroleuid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editrolecontact (@flduid uniqueidentifier,@fldroleuid uniqueidentifier ,@fldtype varchar(255),@fldstatus bit,@fldname varchar(255),@fldemail varchar(50),@fldphonenumber varchar(50),@fldfax varchar(50),@fldnote varchar(max),@fldflags bigint ,@fldupdated varchar(14))
as
begin
	update UMS.rolescontacts set  fldroleuid=@fldroleuid,fldtype=@fldtype,fldname=@fldname,fldemail=@fldemail,fldphonenumber=@fldphonenumber,fldfax=@fldfax,fldnote=@fldnote,fldstatus=@fldstatus,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleterolecontact' and s.name='UMS')

begin
exec('create procedure UMS.Deleterolecontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolescontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleterolecontact (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolescontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolecontactById' and s.name='UMS')

begin
exec('create procedure UMS.getrolecontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolescontacts where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getrolecontactById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolescontacts where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllrolescontacts' and s.name='UMS')

begin
exec('create procedure UMS.getAllrolescontacts
as
begin
	select * from UMS.rolescontacts
end;')
end
else
begin
exec('alter procedure UMS.getAllrolescontacts
as
begin
	select * from UMS.rolescontacts
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolescontactsByroleId' and s.name='UMS')

begin
exec('create procedure UMS.getrolescontactsByroleId(@fldroleuid uniqueidentifier)
as
begin
	select * from UMS.rolescontacts where fldroleuid=@fldroleuid
end;')
end
else
begin
exec('alter procedure UMS.getrolescontactsByroleId(@fldroleuid uniqueidentifier)
as
begin
	select * from UMS.rolescontacts where fldroleuid=@fldroleuid
end;')
end

go


-------------------- positions privilages -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addpositionprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Addpositionprivilage (@fldpositionuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.positionsprivilages (fldpositionuid,fldprivilageuid,fldattributes,fldflags,fldcreated,fldupdated)  values (@fldpositionuid,@fldprivilageuid,@fldattributes,@fldflags,@fldcreated,@fldupdated) 
end;')
end
else
begin
exec('alter procedure UMS.Addpositionprivilage (@fldpositionuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.positionsprivilages (fldpositionuid,fldprivilageuid,fldattributes,fldflags,fldcreated,fldupdated)  values (@fldpositionuid,@fldprivilageuid,@fldattributes,@fldflags,@fldcreated,@fldupdated) 
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editpositionprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Editpositionprivilage (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.positionsprivilages set  fldpositionuid=@fldpositionuid,fldprivilageuid=@fldprivilageuid,fldattributes=@fldattributes,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editpositionprivilage (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.positionsprivilages set  fldpositionuid=@fldpositionuid,fldprivilageuid=@fldprivilageuid,fldattributes=@fldattributes,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletepositionprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Deletepositionprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.positionsprivilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletepositionprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.positionsprivilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpostitionprivilageById' and s.name='UMS')

begin
exec('create procedure UMS.getpostitionprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positionsprivilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getpostitionprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positionsprivilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllpositionsprivilages' and s.name='UMS')

begin
exec('create procedure UMS.getAllpositionsprivilages
as
begin
	select * from UMS.positionsprivilages
end;')
end
else
begin
exec('alter procedure UMS.getAllpositionsprivilages
as
begin
	select * from UMS.positionsprivilages
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpositionsprivilagesByprivilageId' and s.name='UMS')

begin
exec('create procedure UMS.getpositionsprivilagesByprivilageId(@fldprivilageuid uniqueidentifier)
as
begin
	select * from UMS.positionsprivilages where fldprivilageuid=@fldprivilageuid
end;')
end
else
begin
exec('alter procedure UMS.getpositionsprivilagesByprivilageId(@fldprivilageuid uniqueidentifier)
as
begin
	select * from UMS.positionsprivilages where fldprivilageuid=@fldprivilageuid
end;')
end

go


-------------------- deparrtments privilages -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Adddeparrtmentprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Adddeparrtmentprivilage (@flddeparrtmentuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.deparrtmentsprivilages (flddeparrtmentuid,fldprivilageuid,fldattributes,fldflags,fldcreated,fldupdated)  values (@flddeparrtmentuid,@fldprivilageuid,@fldattributes,@fldflags,@fldcreated,@fldupdated) 
end;')
end
else
begin
exec('alter procedure UMS.Adddeparrtmentprivilage (@flddeparrtmentuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.deparrtmentsprivilages (flddeparrtmentuid,fldprivilageuid,fldattributes,fldflags,fldcreated,fldupdated)  values (@flddeparrtmentuid,@fldprivilageuid,@fldattributes,@fldflags,@fldcreated,@fldupdated) 
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editdeparrtmentprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Editdeparrtmentprivilage (@flduid uniqueidentifier,@flddeparrtmentuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.deparrtmentsprivilages set  flddeparrtmentuid=@flddeparrtmentuid,fldprivilageuid=@fldprivilageuid,fldattributes=@fldattributes,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editdeparrtmentprivilage (@flduid uniqueidentifier,@flddeparrtmentuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.deparrtmentsprivilages set  flddeparrtmentuid=@flddeparrtmentuid,fldprivilageuid=@fldprivilageuid,fldattributes=@fldattributes,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletedeparrtmentprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Deletedeparrtmentprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.deparrtmentsprivilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletedeparrtmentprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.deparrtmentsprivilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpostitionprivilageById' and s.name='UMS')

begin
exec('create procedure UMS.getpostitionprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.deparrtmentsprivilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getpostitionprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.deparrtmentsprivilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldeparrtmentsprivilages' and s.name='UMS')

begin
exec('create procedure UMS.getAlldeparrtmentsprivilages
as
begin
	select * from UMS.deparrtmentsprivilages
end;')
end
else
begin
exec('alter procedure UMS.getAlldeparrtmentsprivilages
as
begin
	select * from UMS.deparrtmentsprivilages
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdeparrtmentsprivilagesByprivilageId' and s.name='UMS')

begin
exec('create procedure UMS.getdeparrtmentsprivilagesByprivilageId(@fldprivilageuid uniqueidentifier)
as
begin
	select * from UMS.deparrtmentsprivilages where fldprivilageuid=@fldprivilageuid
end;')
end
else
begin
exec('alter procedure UMS.getdeparrtmentsprivilagesByprivilageId(@fldprivilageuid uniqueidentifier)
as
begin
	select * from UMS.deparrtmentsprivilages where fldprivilageuid=@fldprivilageuid
end;')
end

go

-------------------- roles privilages -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addroleprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Addroleprivilage (@fldroleuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.rolesprivilages (fldroleuid,fldprivilageuid,fldattributes,fldflags,fldcreated,fldupdated)  values (@fldroleuid,@fldprivilageuid,@fldattributes,@fldflags,@fldcreated,@fldupdated) 
end;')
end
else
begin
exec('alter procedure UMS.Addroleprivilage (@fldroleuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldcreated varchar(14),@fldupdated varchar(14))
as
begin
	insert into UMS.rolesprivilages (fldroleuid,fldprivilageuid,fldattributes,fldflags,fldcreated,fldupdated)  values (@fldroleuid,@fldprivilageuid,@fldattributes,@fldflags,@fldcreated,@fldupdated) 
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editroleprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Editroleprivilage (@flduid uniqueidentifier,@fldroleuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.rolesprivilages set  fldroleuid=@fldroleuid,fldprivilageuid=@fldprivilageuid,fldattributes=@fldattributes,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editroleprivilage (@flduid uniqueidentifier,@fldroleuid uniqueidentifier ,@fldprivilageuid uniqueidentifier,@fldattributes decimal(38,0),@fldflags bigint,@fldupdated varchar(14))
as
begin
	update UMS.rolesprivilages set  fldroleuid=@fldroleuid,fldprivilageuid=@fldprivilageuid,fldattributes=@fldattributes,fldflags=@fldflags,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleteroleprivilage' and s.name='UMS')

begin
exec('create procedure UMS.Deleteroleprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolesprivilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleteroleprivilage (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolesprivilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpostitionprivilageById' and s.name='UMS')

begin
exec('create procedure UMS.getpostitionprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolesprivilages where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getpostitionprivilageById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolesprivilages where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllrolesprivilages' and s.name='UMS')

begin
exec('create procedure UMS.getAllrolesprivilages
as
begin
	select * from UMS.rolesprivilages
end;')
end
else
begin
exec('alter procedure UMS.getAllrolesprivilages
as
begin
	select * from UMS.rolesprivilages
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolesprivilagesByprivilageId' and s.name='UMS')

begin
exec('create procedure UMS.getrolesprivilagesByprivilageId(@fldprivilageuid uniqueidentifier)
as
begin
	select * from UMS.rolesprivilages where fldprivilageuid=@fldprivilageuid
end;')
end
else
begin
exec('alter procedure UMS.getrolesprivilagesByprivilageId(@fldprivilageuid uniqueidentifier)
as
begin
	select * from UMS.rolesprivilages where fldprivilageuid=@fldprivilageuid
end;')
end

go

-------------------- positions responsibilities -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addpositionresponsipility' and s.name='UMS')
begin
exec('create procedure UMS.Addpositionresponsipility (@fldpositionuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldcreated varchar(14),@fldupdated varchar(14) ) 
as
begin
	insert into UMS.positionsresponsipilities (fldpositionuid,fldename,fldlname,fldnote,fldcode,fldisactive,fldflags,fldpriority,fldcreated,fldupdated) values (@fldpositionuid,@fldename,@fldlname,@fldnote,@fldcode,@fldisactive,@fldflags,@fldpriority,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addpositionresponsipility (@fldpositionuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldcreated varchar(14),@fldupdated varchar(14) ) 
as
begin
	insert into UMS.positionsresponsipilities (fldpositionuid,fldename,fldlname,fldnote,fldcode,fldisactive,fldflags,fldpriority,fldcreated,fldupdated) values (@fldpositionuid,@fldename,@fldlname,@fldnote,@fldcode,@fldisactive,@fldflags,@fldpriority,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editpositionresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Editpositionresponsipility (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldupdated varchar(14) ) 
as
begin
	update UMS.positionsresponsipilities set fldpositionuid=@fldpositionuid,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldcode=@fldcode,fldisactive=@fldisactive,fldflags=@fldflags,fldpriority=@fldpriority,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editpositionresponsipility (@flduid uniqueidentifier,@fldpositionuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldupdated varchar(14) ) 
as
begin
	update UMS.positionsresponsipilities set fldpositionuid=@fldpositionuid,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldcode=@fldcode,fldisactive=@fldisactive,fldflags=@fldflags,fldpriority=@fldpriority,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletepositionresponsipility' and s.name='UMS')
begin
exec('create procedure UMS.Deletepositionresponsipility (@flduid uniqueidentifier)
as
begin
	delete from UMS.positionsresponsipilities where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletepositionresponsipility (@flduid uniqueidentifier)
as
begin
	delete from UMS.positionsresponsipilities where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpositionresponsipilityById' and s.name='UMS')

begin
exec('create procedure UMS.getpositionresponsipilityById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positionsresponsipilities where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getpositionresponsipilityById (@flduid uniqueidentifier)
as
begin
	select * from UMS.positionsresponsipilities where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllpositionsresponsipilities' and s.name='UMS')

begin
exec('create procedure UMS.getAllpositionsresponsipilities
as
begin
	select * from UMS.positionsresponsipilities
end;')
end
else
begin
exec('alter procedure UMS.getAllpositionsresponsipilities
as
begin
	select * from UMS.positionsresponsipilities
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getpositionsresponsipilitiesbypositionid' and s.name='UMS')

begin
exec('create procedure UMS.getpositionsresponsipilitiesbypositionid(@fldpositionuid uniqueidentifier)
as
begin
	select * from UMS.positionsresponsipilities where fldpositionuid=@fldpositionuid
end;')
end
else
begin
exec('alter procedure UMS.getpositionsresponsipilitiesbypositionid(@fldpositionuid uniqueidentifier)
as
begin
	select * from UMS.positionsresponsipilities where fldpositionuid=@fldpositionuid
end;')
end

go


-------------------- departments responsibilities -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Adddepartmentresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Adddepartmentresponsipility (@flddepartmentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldcreated varchar(14),@fldupdated varchar(14) ) 
as
begin
	insert into UMS.departmentsresponsipilities (flddepartmentuid,fldename,fldlname,fldnote,fldcode,fldisactive,fldflags,fldpriority,fldcreated,fldupdated) values (@flddepartmentuid,@fldename,@fldlname,@fldnote,@fldcode,@fldisactive,@fldflags,@fldpriority,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Adddepartmentresponsipility (@flddepartmentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldcreated varchar(14),@fldupdated varchar(14) ) 
as
begin
	insert into UMS.departmentsresponsipilities (flddepartmentuid,fldename,fldlname,fldnote,fldcode,fldisactive,fldflags,fldpriority,fldcreated,fldupdated) values (@flddepartmentuid,@fldename,@fldlname,@fldnote,@fldcode,@fldisactive,@fldflags,@fldpriority,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editdepartmentresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Editdepartmentresponsipility (@flduid uniqueidentifier,@flddepartmentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldupdated varchar(14) ) 
as
begin
	update UMS.departmentsresponsipilities set flddepartmentuid=@flddepartmentuid,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldcode=@fldcode,fldisactive=@fldisactive,fldflags=@fldflags,fldpriority=@fldpriority,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editdepartmentresponsipility (@flduid uniqueidentifier,@flddepartmentuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldupdated varchar(14) ) 
as
begin
	update UMS.departmentsresponsipilities set flddepartmentuid=@flddepartmentuid,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldcode=@fldcode,fldisactive=@fldisactive,fldflags=@fldflags,fldpriority=@fldpriority,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletedepartmentresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Deletedepartmentresponsipility (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentsresponsipilities where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletedepartmentresponsipility (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentsresponsipilities where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentresponsipilityById' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentresponsipilityById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentsresponsipilities where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentresponsipilityById (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentsresponsipilities where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldepartmentsresponsipilities' and s.name='UMS')

begin
exec('create procedure UMS.getAlldepartmentsresponsipilities
as
begin
	select * from UMS.departmentsresponsipilities
end;')
end
else
begin
exec('alter procedure UMS.getAlldepartmentsresponsipilities
as
begin
	select * from UMS.departmentsresponsipilities
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentsresponsipilitiesbydepartmentid' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentsresponsipilitiesbydepartmentid(@flddepartmentuid uniqueidentifier)
as
begin
	select * from UMS.departmentsresponsipilities where flddepartmentuid=@flddepartmentuid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentsresponsipilitiesbydepartmentid(@flddepartmentuid uniqueidentifier)
as
begin
	select * from UMS.departmentsresponsipilities where flddepartmentuid=@flddepartmentuid
end;')
end

go


-------------------- roles responsibilities -----------------------
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addroleresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Addroleresponsipility (@fldroleuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldcreated varchar(14),@fldupdated varchar(14) ) 
as
begin
	insert into UMS.rolesresponsipilities (fldroleuid,fldename,fldlname,fldnote,fldcode,fldisactive,fldflags,fldpriority,fldcreated,fldupdated) values (@fldroleuid,@fldename,@fldlname,@fldnote,@fldcode,@fldisactive,@fldflags,@fldpriority,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addroleresponsipility (@fldroleuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldcreated varchar(14),@fldupdated varchar(14) ) 
as
begin
	insert into UMS.rolesresponsipilities (fldroleuid,fldename,fldlname,fldnote,fldcode,fldisactive,fldflags,fldpriority,fldcreated,fldupdated) values (@fldroleuid,@fldename,@fldlname,@fldnote,@fldcode,@fldisactive,@fldflags,@fldpriority,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editroleresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Editroleresponsipility (@flduid uniqueidentifier,@fldroleuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldupdated varchar(14) ) 
as
begin
	update UMS.rolesresponsipilities set fldroleuid=@fldroleuid,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldcode=@fldcode,fldisactive=@fldisactive,fldflags=@fldflags,fldpriority=@fldpriority,fldupdated=@fldupdated where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editroleresponsipility (@flduid uniqueidentifier,@fldroleuid uniqueidentifier,@fldename varchar(250),@fldlname varchar(250),@fldnote varchar(max),@fldcode varchar(250),@fldisactive bit,@fldflags bigint,@fldpriority char(1),@fldupdated varchar(14) ) 
as
begin
	update UMS.rolesresponsipilities set fldroleuid=@fldroleuid,fldename=@fldename,fldlname=@fldlname,fldnote=@fldnote,fldcode=@fldcode,fldisactive=@fldisactive,fldflags=@fldflags,fldpriority=@fldpriority,fldupdated=@fldupdated where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleteroleresponsipility' and s.name='UMS')

begin
exec('create procedure UMS.Deleteroleresponsipility (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolesresponsipilities where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleteroleresponsipility (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolesresponsipilities where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getroleresponsipilityById' and s.name='UMS')

begin
exec('create procedure UMS.getroleresponsipilityById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolesresponsipilities where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getroleresponsipilityById (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolesresponsipilities where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllrolesresponsipilities' and s.name='UMS')

begin
exec('create procedure UMS.getAllrolesresponsipilities
as
begin
	select * from UMS.rolesresponsipilities
end;')
end
else
begin
exec('alter procedure UMS.getAllrolesresponsipilities
as
begin
	select * from UMS.rolesresponsipilities
end;')
end

go

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolesresponsipilitiesbyroleid' and s.name='UMS')

begin
exec('create procedure UMS.getrolesresponsipilitiesbyroleid(@fldroleuid uniqueidentifier)
as
begin
	select * from UMS.rolesresponsipilities where fldroleuid=@fldroleuid
end;')
end
else
begin
exec('alter procedure UMS.getrolesresponsipilitiesbyroleid(@fldroleuid uniqueidentifier)
as
begin
	select * from UMS.rolesresponsipilities where fldroleuid=@fldroleuid
end;')
end

go


-------------------- users attachments -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='AdduserAttachment' and s.name='UMS')

begin
exec('create procedure UMS.AdduserAttachment (@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.usersattachments (flduseruid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@flduseruid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.AdduserAttachment (@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.usersattachments (flduseruid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@flduseruid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EdituserAttachment' and s.name='UMS')

begin
exec('create procedure UMS.EdituserAttachment (@flduid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldupdated varchar(14) )
as
begin
	update UMS.usersattachments set flduseruid=@flduseruid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.EdituserAttachment (@flduid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldupdated varchar(14) )
as
begin
	update UMS.usersattachments set flduseruid=@flduseruid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='DeleteuserAttachment' and s.name='UMS')

begin
exec('create procedure UMS.DeleteuserAttachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.usersattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.DeleteuserAttachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.usersattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserAttachmentByid' and s.name='UMS')

begin
exec('create procedure UMS.getuserAttachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.usersattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getuserAttachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.usersattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllusersAttachments' and s.name='UMS')

begin
exec('create procedure UMS.getAllusersAttachments
as
begin
	select * from UMS.usersattachments
end;')
end
else
begin
exec('alter procedure UMS.getAllusersAttachments
as
begin
	select * from UMS.usersattachments
end;')
end


if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getusersattachmentsByuserId' and s.name='UMS')

begin
exec('create procedure UMS.getusersattachmentsByuserId(@flduserid uniqueidentifier)
as
begin
	select * from UMS.usersattachments where flduseruid=@flduserid
end;')
end
else
begin
exec('alter procedure UMS.getusersattachmentsByuserId(@flduserid uniqueidentifier)
as
begin
	select * from UMS.usersattachments where flduseruid=@flduserid
end;')
end

go
-------------------- users positions attachments -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='AdduserpositionAttachment' and s.name='UMS')

begin
exec('create procedure UMS.AdduserpositionAttachment (@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.userspositionsattachments (flduserpositionuid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@flduserpositionuid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.AdduserpositionAttachment (@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.userspositionsattachments (flduserpositionuid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@flduserpositionuid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='EdituserpositionAttachment' and s.name='UMS')

begin
exec('create procedure UMS.EdituserpositionAttachment (@flduid uniqueidentifier,@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldupdated varchar(14) )
as
begin
	update UMS.userspositionsattachments set flduserpositionuid=@flduserpositionuid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.EdituserpositionAttachment (@flduid uniqueidentifier,@flduserpositionuid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldupdated varchar(14) )
as
begin
	update UMS.userspositionsattachments set flduserpositionuid=@flduserpositionuid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='DeleteuserpositionAttachment' and s.name='UMS')

begin
exec('create procedure UMS.DeleteuserpositionAttachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.userspositionsattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.DeleteuserpositionAttachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.userspositionsattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserpositionAttachmentByid' and s.name='UMS')

begin
exec('create procedure UMS.getuserpositionAttachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.userspositionsattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getuserpositionAttachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.userspositionsattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlluserspositionsattachments' and s.name='UMS')

begin
exec('create procedure UMS.getAlluserspositionsattachments
as
begin
	select * from UMS.userspositionsattachments
end;')
end
else
begin
exec('alter procedure UMS.getAlluserspositionsattachments
as
begin
	select * from UMS.userspositionsattachments
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getuserspositionsattachmentsByuserId' and s.name='UMS')

begin
exec('create procedure UMS.getuserspositionsattachmentsByuserId(@flduserpositionuid uniqueidentifier)
as
begin
	select * from UMS.userspositionsattachments where flduserpositionuid=@flduserpositionuid
end;')
end
else
begin
exec('alter procedure UMS.getuserspositionsattachmentsByuserId(@flduserpositionuid uniqueidentifier)
as
begin
	select * from UMS.userspositionsattachments where flduserpositionuid=@flduserpositionuid
end;')
end

go

-------------------- department positions attachments -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Adddepartmentpositionattachment' and s.name='UMS')

begin
exec('create procedure UMS.Adddepartmentpositionattachment (@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.departmentspositionsattachments (flddepartmentpositionuid,flduseruid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@flddepartmentpositionuid,@flduseruid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Adddepartmentpositionattachment (@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.departmentspositionsattachments (flddepartmentpositionuid,flduseruid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@flddepartmentpositionuid,@flduseruid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editdepartmentpositionattachment' and s.name='UMS')

begin
exec('create procedure UMS.Editdepartmentpositionattachment (@flduid uniqueidentifier,@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldupdated varchar(14) )
as
begin
	update UMS.departmentspositionsattachments set flddepartmentpositionuid=@flddepartmentpositionuid,flduseruid=@flduseruid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editdepartmentpositionattachment (@flduid uniqueidentifier,@flddepartmentpositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldupdated varchar(14) )
as
begin
	update UMS.departmentspositionsattachments set flddepartmentpositionuid=@flddepartmentpositionuid,flduseruid=@flduseruid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deletedepartmentpositionattachment' and s.name='UMS')

begin
exec('create procedure UMS.Deletedepartmentpositionattachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentspositionsattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deletedepartmentpositionattachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.departmentspositionsattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentpositionattachmentByid' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentpositionattachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentpositionattachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAlldepartmentspositionsattachments' and s.name='UMS')

begin
exec('create procedure UMS.getAlldepartmentspositionsattachments
as
begin
	select * from UMS.departmentspositionsattachments
end;')
end
else
begin
exec('alter procedure UMS.getAlldepartmentspositionsattachments
as
begin
	select * from UMS.departmentspositionsattachments
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentspositionsattachmentsBydepartmentpositionId' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentspositionsattachmentsBydepartmentpositionId(@flddepartmentpositionuid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsattachments where flddepartmentpositionuid=@flddepartmentpositionuid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentspositionsattachmentsBydepartmentpositionId(@flddepartmentpositionuid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsattachments where flddepartmentpositionuid=@flddepartmentpositionuid
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getdepartmentspositionsattachmentsByuserId' and s.name='UMS')

begin
exec('create procedure UMS.getdepartmentspositionsattachmentsByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsattachments where flduseruid=@flduseruid
end;')
end
else
begin
exec('alter procedure UMS.getdepartmentspositionsattachmentsByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.departmentspositionsattachments where flduseruid=@flduseruid
end;')
end

go
-------------------- roles positions attachments -----------------------

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Addrolepositionattachment' and s.name='UMS')

begin
exec('create procedure UMS.Addrolepositionattachment (@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.rolespositionsattachments (fldrolepositionuid,flduseruid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@fldrolepositionuid,@flduseruid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end
else
begin
exec('alter procedure UMS.Addrolepositionattachment (@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint,@fldcreated varchar(14) ,@fldupdated varchar(14) )
as
begin
	insert into UMS.rolespositionsattachments (fldrolepositionuid,flduseruid,fldtype,fldfilepath,fldfilecaption,fldnote,fldfileext,fldflags,fldcreated,fldupdated) values (@fldrolepositionuid,@flduseruid,@fldtype,@fldfilepath,@fldfilecaption,@fldnote,@fldfileext,@fldflags,@fldcreated,@fldupdated)
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Editrolepositionattachment' and s.name='UMS')

begin
exec('create procedure UMS.Editrolepositionattachment (@flduid uniqueidentifier,@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint ,@fldupdated varchar(14) )
as
begin
	update UMS.rolespositionsattachments set fldrolepositionuid=@fldrolepositionuid,flduseruid=@flduseruid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Editrolepositionattachment (@flduid uniqueidentifier,@fldrolepositionuid uniqueidentifier,@flduseruid uniqueidentifier,@fldtype varchar(255),@fldfilepath varchar(max),@fldfilecaption varchar(255),@fldnote varchar(max),@fldfileext varchar(250),@fldflags bigint ,@fldupdated varchar(14) )
as
begin
	update UMS.rolespositionsattachments set fldrolepositionuid=@fldrolepositionuid,flduseruid=@flduseruid,fldtype=@fldtype,fldfilepath=@fldfilepath,fldfilecaption=@fldfilecaption,fldnote=@fldnote,fldfileext=@fldfileext,fldflags=@fldflags,fldupdated=@fldupdated  where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='Deleterolepositionattachment' and s.name='UMS')

begin
exec('create procedure UMS.Deleterolepositionattachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolespositionsattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.Deleterolepositionattachment (@flduid uniqueidentifier)
as
begin
	delete from UMS.rolespositionsattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolepositionattachmentByid' and s.name='UMS')

begin
exec('create procedure UMS.getrolepositionattachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsattachments where flduid=@flduid
end;')
end
else
begin
exec('alter procedure UMS.getrolepositionattachmentByid (@flduid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsattachments where flduid=@flduid
end;')
end

go
if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getAllrolespositionsattachments' and s.name='UMS')

begin
exec('create procedure UMS.getAllrolespositionsattachments
as
begin
	select * from UMS.rolespositionsattachments
end;')
end
else
begin
exec('alter procedure UMS.getAllrolespositionsattachments
as
begin
	select * from UMS.rolespositionsattachments
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolespositionsattachmentsByrolepositionId' and s.name='UMS')
begin
exec('create procedure UMS.getrolespositionsattachmentsByrolepositionId(@fldrolepositionuid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsattachments where fldrolepositionuid=@fldrolepositionuid
end;')
end
else
begin
exec('alter procedure UMS.getrolespositionsattachmentsByrolepositionId(@fldrolepositionuid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsattachments where fldrolepositionuid=@fldrolepositionuid
end;')
end

if not exists (select * from sys.procedures p inner join sys.schemas s on (p.schema_id=s.schema_id) where p.name='getrolespositionsattachmentsByuserId' and s.name='UMS')
begin
exec('create procedure UMS.getrolespositionsattachmentsByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsattachments where flduseruid=@flduseruid
end;')
end
else
begin
exec('alter procedure UMS.getrolespositionsattachmentsByuserId(@flduseruid uniqueidentifier)
as
begin
	select * from UMS.rolespositionsattachments where flduseruid=@flduseruid
end;')
end

go
