/*==============================================================*/
/* Nom de SGBD :  MySQL 5.0                                     */
/* Date de cr�ation :  15/10/2023 19:41:41                      */
/*==============================================================*/


drop database if exists GSTOCK;
create database if not exists GSTOCK;
use GSTOCK;


drop table if exists Materiel;

drop table if exists Reservation;

drop table if exists Utililisateur;


/*==============================================================*/
/* Table : Materiel                                             */
/*==============================================================*/
create table Materiel
(
   idMateriel           int AUTO_INCREMENT not null,
   nomMateriel          varchar(254),
   description          varchar(254),
   quantite             int,
   emplacement          varchar(254),
   statut               varchar(24),
   primary key (idMateriel)
);

/*==============================================================*/
/* Table : Reservation                                          */
/*==============================================================*/
create table Reservation
(
   identifiant          int AUTO_INCREMENT not null,
   idUser               int not null,
   idMateriel           int not null,
   dateDebut            datetime,
   dateFin              datetime,
   primary key (identifiant)
);


/*==============================================================*/
/* Table : Utililisateur                                        */
/*==============================================================*/
create table Utililisateur
(
   idUser               int auto_increment not null,
   nomUser              varchar(254),
   prenomUser           varchar(254),
   password             varchar(254),
   primary key (idUser)
);

alter table Reservation add constraint FK_Reservation foreign key (idMateriel)
      references Materiel (idMateriel) on delete restrict on update restrict;

alter table Reservation add constraint FK_Reservation foreign key (identifiant)
      references Reservation (identifiant) on delete restrict on update restrict;

alter table Reservation add constraint FK_Reservation2 foreign key (idUser)
      references Utililisateur (idUser) on delete restrict on update restrict;

