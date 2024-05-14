/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     14/05/2024 7:07:34 PM                        */
/*==============================================================*/
DROP DATABASE db_project_pad;
CREATE DATABASE db_project_pad;

DROP TABLE IF EXISTS BILLS;

DROP TABLE IF EXISTS CATEGORIES;

DROP TABLE IF EXISTS CUSTOMERS;

DROP TABLE IF EXISTS D_BILLS;

DROP TABLE IF EXISTS D_FINES;

DROP TABLE IF EXISTS FACILITIES;

DROP TABLE IF EXISTS FINES;

drop table if exists ROOMS;

drop table if exists ROOM_INVENTORY;

drop table if exists STAFFS;

drop table if exists VOUCHERS;

/*==============================================================*/
/* Table: BILLS                                                 */
/*==============================================================*/
create table BILLS
(
   BILL_ID              varchar(16) not null,
   ROOM_ID              varchar(5) not null,
   VOUCHER_ID           varchar(12),
   STAFF_ID             varchar(4) not null,
   CUSTOMER_ID          varchar(16) not null,
   CHECKIN_DATE         date not null,
   CHECKOUT_DATE        date not null,
   BILL_TOTAL           bigint not null,
   BILL_GRANDTOTAL      bigint not null,
   BILL_STATUS          bool not null,
   primary key (BILL_ID)
);

/*==============================================================*/
/* Table: CATEGORIES                                            */
/*==============================================================*/
create table CATEGORIES
(
   CATEGORY_ID          varchar(3) not null,
   CATEGORY_NAME        varchar(16) not null,
   primary key (CATEGORY_ID)
);

/*==============================================================*/
/* Table: CUSTOMERS                                             */
/*==============================================================*/
create table CUSTOMERS
(
   CUSTOMER_ID          varchar(16) not null,
   CUSTOMER_NAME        varchar(64) not null,
   CUSTOMER_ADDRESS     varchar(64) not null,
   CUSTOMER_PHONE       varchar(13) not null,
   primary key (CUSTOMER_ID)
);

/*==============================================================*/
/* Table: D_BILLS                                               */
/*==============================================================*/
create table D_BILLS
(
   FACILITIES_ID        varchar(5) not null,
   BILL_ID              varchar(16) not null,
   primary key (FACILITIES_ID, BILL_ID)
);

/*==============================================================*/
/* Table: D_FINES                                               */
/*==============================================================*/
create table D_FINES
(
   FINE_ID              varchar(8) not null,
   BILL_ID              varchar(16) not null,
   primary key (FINE_ID, BILL_ID)
);

/*==============================================================*/
/* Table: FACILITIES                                            */
/*==============================================================*/
create table FACILITIES
(
   FACILITIES_ID        varchar(5) not null,
   FACILITIES_NAME      varchar(32) not null,
   PRICE                bigint not null,
   primary key (FACILITIES_ID)
);

/*==============================================================*/
/* Table: FINES                                                 */
/*==============================================================*/
create table FINES
(
   FINE_ID              varchar(8) not null,
   FINE_NAME            varchar(32) not null,
   FINE                 bigint not null,
   primary key (FINE_ID)
);

/*==============================================================*/
/* Table: ROOMS                                                 */
/*==============================================================*/
create table ROOMS
(
   ROOM_ID              varchar(5) not null,
   CATEGORY_ID          varchar(3) not null,
   ROOM_PRICE           bigint not null,
   IS_USABLE            bool not null,
   primary key (ROOM_ID)
);

/*==============================================================*/
/* Table: ROOM_INVENTORY                                        */
/*==============================================================*/
create table ROOM_INVENTORY
(
   ROOM_INVENTORY_ID    int not null,
   FINE_ID              varchar(8) not null,
   ROOM_ID              varchar(5) not null,
   ROOM_INVENTORY_NAME  varchar(32) not null,
   primary key (ROOM_INVENTORY_ID)
);

/*==============================================================*/
/* Table: STAFFS                                                */
/*==============================================================*/
create table STAFFS
(
   STAFF_ID             varchar(4) not null,
   STAFF_NAME           varchar(64) not null,
   STAFF_EMAIL          varchar(64) not null,
   STAFF_PHONE          varchar(13) not null,
   STAFF_IS_ACTIVE      bool not null,
   STAFF_IS_MANAGER     bool not null,
   STAFF_USERNAME       varchar(32) not null,
   STAFF_PASSWORD       varchar(255) not null,
   primary key (STAFF_ID)
);

/*==============================================================*/
/* Table: VOUCHERS                                              */
/*==============================================================*/
create table VOUCHERS
(
   VOUCHER_ID           varchar(12) not null,
   VOUCHER_NAME         varchar(64) not null,
   VOUCHER              bigint not null,
   DATE_START           date not null,
   DATE_END             date not null,
   primary key (VOUCHER_ID)
);

alter table BILLS add constraint FK_RELATIONSHIP_1 foreign key (CUSTOMER_ID)
      references CUSTOMERS (CUSTOMER_ID) on delete restrict on update restrict;

alter table BILLS add constraint FK_RELATIONSHIP_2 foreign key (ROOM_ID)
      references ROOMS (ROOM_ID) on delete restrict on update restrict;

alter table BILLS add constraint FK_RELATIONSHIP_5 foreign key (STAFF_ID)
      references STAFFS (STAFF_ID) on delete restrict on update restrict;

alter table BILLS add constraint FK_RELATIONSHIP_6 foreign key (VOUCHER_ID)
      references VOUCHERS (VOUCHER_ID) on delete restrict on update restrict;

alter table D_BILLS add constraint FK_RELATIONSHIP_7 foreign key (FACILITIES_ID)
      references FACILITIES (FACILITIES_ID) on delete restrict on update restrict;

alter table D_BILLS add constraint FK_RELATIONSHIP_8 foreign key (BILL_ID)
      references BILLS (BILL_ID) on delete restrict on update restrict;

alter table D_FINES add constraint FK_RELATIONSHIP_3 foreign key (FINE_ID)
      references FINES (FINE_ID) on delete restrict on update restrict;

alter table D_FINES add constraint FK_RELATIONSHIP_4 foreign key (BILL_ID)
      references BILLS (BILL_ID) on delete restrict on update restrict;

alter table ROOMS add constraint FK_RELATIONSHIP_9 foreign key (CATEGORY_ID)
      references CATEGORIES (CATEGORY_ID) on delete restrict on update restrict;

alter table ROOM_INVENTORY add constraint FK_RELATIONSHIP_10 foreign key (ROOM_ID)
      references ROOMS (ROOM_ID) on delete restrict on update restrict;

alter table ROOM_INVENTORY add constraint FK_RELATIONSHIP_11 foreign key (FINE_ID)
      references FINES (FINE_ID) on delete restrict on update restrict;

