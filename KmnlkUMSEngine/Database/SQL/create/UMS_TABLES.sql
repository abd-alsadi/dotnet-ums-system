if not exists (select * from sys.databases where name=N'KmnlkDB')
begin
  exec ('create database KmnlkDB;');
end;
go

use KmnlkDB;

go

if not exists (select * from sys.schemas where name=N'UMS')
begin
   exec ('create schema UMS;');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'settings' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.settings(
flduid uniqueidentifier not null default newid(),
fldname varchar(250) not null ,
fldvalue varchar(max) not null ,
fldnote varchar(max) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);')
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'users' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.users(
flduid uniqueidentifier not null default newid(),
flddefaultpositionuid uniqueidentifier null ,
fldname varchar(50) not null ,
fldpassword varchar(255) null ,
flddigitalsignatureimage varbinary(max) null ,
fldnote varchar(max) null ,
fldflags bigint null ,
fldblocked bit null ,
fldlastlogin varchar(14) null,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'profiles' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.profiles(
flduid uniqueidentifier not null default newid(),
flduseruid uniqueidentifier not null,
fldefirstname varchar(50) null ,
fldefamilyname varchar(50) null ,
fldelocalfirstname varchar(200) null ,
fldelocalfamilyname varchar(200) null ,
fldetitle varchar(200) null ,
fldelocaltitle varchar(200) null ,
fldenickname varchar(50) null ,
fldedisplayname varchar(250) null ,
fldlfirstname varchar(50) null ,
fldlfamilyname varchar(50) null ,
fldllocalfirstname varchar(200) null ,
fldllocalfamilyname varchar(200) null ,
fldltitle varchar(200) null ,
fldllocaltitle varchar(200) null ,
fldlnickname varchar(50) null ,
fldldisplayname varchar(250) null ,
fldphonenumber varchar(50) null ,
fldemail varchar(50) null ,
fldfax varchar(50) null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'roles' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.roles(
flduid uniqueidentifier not null default newid(),
fldpositionmanager uniqueidentifier null,
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldnote varchar(max) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'positions' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.positions(
flduid uniqueidentifier not null default newid(),
fldusermanager uniqueidentifier null,
fldname varchar(250) unique not null ,
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldgrade varchar(10) null ,
fldnote varchar(max) null ,
fldflags bigint null ,
fldblocked bit null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'positionsresponsipilities' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.positionsresponsipilities(
flduid uniqueidentifier not null default newid(),
fldpositionuid uniqueidentifier not null ,
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldnote varchar(max) null ,
fldcode varchar(250) null ,
fldisactive bit null ,
fldflags bigint null ,
fldpriority char(1) ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departmentsresponsipilities' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departmentsresponsipilities(
flduid uniqueidentifier not null default newid(),
flddepartmentuid uniqueidentifier not null ,
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldnote varchar(max) null ,
fldcode varchar(250) null ,
fldisactive bit null ,
fldflags bigint null ,
fldpriority char(1) ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'rolesresponsipilities' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.rolesresponsipilities(
flduid uniqueidentifier not null default newid(),
fldroleuid uniqueidentifier not null ,
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldnote varchar(max) null ,
fldcode varchar(250) null ,
fldisactive bit null ,
fldflags bigint null ,
fldpriority char(1) ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departments' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departments(
flduid uniqueidentifier not null default newid(),
fldparentuid uniqueidentifier null,
fldpositionmanager uniqueidentifier null,
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldgrade varchar(10) null ,
fldcode varchar(50) null ,
fldlevel varchar(50) null ,
fldfax varchar(50) null ,
fldparentcode varchar(50) null ,
fldnote varchar(max) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'privilages' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.privilages(
flduid uniqueidentifier not null default newid(),
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldprivilagenumber decimal(38,0) null ,
fldtype decimal(38,0) null,
fldnote varchar(max) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'operations' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.operations(
flduid uniqueidentifier not null default newid(),
fldename varchar(250) not null ,
fldlname varchar(250) not null ,
fldoperationnumber decimal(38,0) null ,
fldnote varchar(max) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);')
end;
go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'userspositions' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.userspositions(
flduid uniqueidentifier not null default newid(),
fldpositionuid uniqueidentifier not null ,
flduseruid uniqueidentifier not null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null,
flddeleted bit not null default 0
);');
end;
go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'rolespositions' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.rolespositions(
flduid uniqueidentifier not null default newid(),
fldpositionuid uniqueidentifier not null ,
fldroleuid uniqueidentifier not null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null,
flddeleted bit not null default 0
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departmentspositions' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departmentspositions(
flduid uniqueidentifier not null default newid(),
fldpositionuid uniqueidentifier not null ,
flddepartmentuid uniqueidentifier not null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null,
flddeleted bit not null default 0
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'delegations' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.delegations(
flduid uniqueidentifier not null default newid(),
fldfromuseruid uniqueidentifier not null ,
fldtouseruid uniqueidentifier not null ,
fldfromdate varchar(14) null ,
fldtodate varchar(14) null ,
fldfromtime varchar(5) null ,
fldtotime varchar(5) null ,
fldisactive bit null ,
fldflags bigint null ,
fldnote varchar(255) null,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'usersnotes' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.usersnotes(
flduid uniqueidentifier not null default newid(),
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
flddate varchar(14) null ,
fldnote varchar(max) not null,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'userspositionsnotes' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.userspositionsnotes(
flduid uniqueidentifier not null default newid(),
flduserpositionuid uniqueidentifier not null ,
fldtype varchar(255) not null ,
flddate varchar(14) null ,
fldnote varchar(max) not null,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go


go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departmentspositionsnotes' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departmentspositionsnotes(
flduid uniqueidentifier not null default newid(),
flddepartmentpositionuid uniqueidentifier not null ,
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
flddate varchar(14) null ,
fldnote varchar(max) not null,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'rolespositionsnotes' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.rolespositionsnotes(
flduid uniqueidentifier not null default newid(),
fldrolepositionuid uniqueidentifier not null ,
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
flddate varchar(14) null ,
fldnote varchar(max) not null,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;

go
if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'userscontacts' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.userscontacts(
flduid uniqueidentifier not null default newid(),
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldname varchar(255) not null ,
fldemail varchar(50) not null ,
fldphonenumber varchar(50) null ,
fldfax varchar(50) null ,
fldnote varchar(max) not null,
fldstatus bit null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'positionscontacts' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.positionscontacts(
flduid uniqueidentifier not null default newid(),
fldpositionuid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldname varchar(255) not null ,
fldemail varchar(50) not null ,
fldphonenumber varchar(50) null ,
fldfax varchar(50) null ,
fldnote varchar(max) not null,
fldstatus bit null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;


go


if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departmentscontacts' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departmentscontacts(
flduid uniqueidentifier not null default newid(),
flddepartmentuid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldname varchar(255) not null ,
fldemail varchar(50) not null ,
fldphonenumber varchar(50) null ,
fldfax varchar(50) null ,
fldnote varchar(max) not null,
fldstatus bit null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'rolescontacts' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.rolescontacts(
flduid uniqueidentifier not null default newid(),
fldroleuid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldname varchar(255) not null ,
fldemail varchar(50) not null ,
fldphonenumber varchar(50) null ,
fldfax varchar(50) null ,
fldnote varchar(max) not null,
fldstatus bit null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'usersattachments' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.usersattachments(
flduid uniqueidentifier not null default newid(),
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldfilepath varchar(max) not null ,
fldfilecaption varchar(255) not null ,
fldnote varchar(max) not null,
fldfileext varchar(250) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'userspositionsattachments' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.userspositionsattachments(
flduid uniqueidentifier not null default newid(),
flduserpositionuid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldfilepath varchar(max) not null ,
fldfilecaption varchar(255) not null ,
fldnote varchar(max) not null,
fldfileext varchar(250) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departmentspositionsattachments' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departmentspositionsattachments(
flduid uniqueidentifier not null default newid(),
flddepartmentpositionuid uniqueidentifier not null ,
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldfilepath varchar(max) not null ,
fldfilecaption varchar(255) not null ,
fldnote varchar(max) not null,
fldfileext varchar(250) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'rolespositionsattachments' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.rolespositionsattachments(
flduid uniqueidentifier not null default newid(),
fldrolepositionuid uniqueidentifier not null ,
flduseruid uniqueidentifier not null ,
fldtype varchar(255) not null ,
fldfilepath varchar(max) not null ,
fldfilecaption varchar(255) not null ,
fldnote varchar(max) not null,
fldfileext varchar(250) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go
if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'profilesfields' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.profilesfields(
flduid uniqueidentifier not null default newid(),
fldprofileuid uniqueidentifier not null ,
fldtype varchar(250) not null ,
fldname varchar(250) not null ,
fldedisplayname varchar(250) not null ,
fldldisplayname varchar(250) not null ,
fldvalue varchar(250) null ,
fldisrequired bit null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'usersmacs' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.usersmacs(
flduid uniqueidentifier not null default newid(),
flduseruid uniqueidentifier not null ,
fldstatus bit not null ,
fldmacaddress varchar(250) not null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'positionsprivilages' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.positionsprivilages(
flduid uniqueidentifier not null default newid(),
fldpositionuid uniqueidentifier not null ,
fldprivilageuid uniqueidentifier not null ,
fldattributes decimal(38,0) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'rolesprivilages' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.rolesprivilages(
flduid uniqueidentifier not null default newid(),
fldroleuid uniqueidentifier not null ,
fldprivilageuid uniqueidentifier not null ,
fldattributes decimal(38,0) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

if not exists (select * from sys.tables t inner join sys.schemas s on (t.schema_id=s.schema_id) where t.name=N'departmentsprivilages' and t.type='U' and s.name='UMS')
begin
exec('create table UMS.departmentsprivilages(
flduid uniqueidentifier not null default newid(),
flddepartmentuid uniqueidentifier not null ,
fldprivilageuid uniqueidentifier not null ,
fldattributes decimal(38,0) null ,
fldflags bigint null ,
fldcreated varchar(14) not null ,
fldupdated varchar(14) not null
);');
end;
go

