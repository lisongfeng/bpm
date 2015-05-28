select * from Product;
select * from ProductLog;

INSERT INTO dbo.Product
        ( ProductId ,
          ProductNum ,
          ProductName ,
          ProductFlag ,
          FactoryId ,
          DealerId ,
          Model ,
          Standard ,
          Price ,
          QuantityUnit
        )
VALUES  ( 11 , -- ProductId - bigint
          'abcd1234' , -- ProductNum - bigint
          '������' , -- ProductName - varchar(100)
          0 , -- Flag - tinyint
          123 , -- FactoryId - bigint
          456 , -- DealerId - bigint
          '��' , -- Model - varchar(50)
          '��' , -- Standard - varchar(50)
          0.0 , -- Price - float
          '��'  -- QuantityUnit - varchar(50)
        )


insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,20,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),2,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),2,20,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),2,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,20,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),2,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),2,50,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');
insert into ProductLog values(11,GETDATE(),1,30,1,'�ֶ�','123','456','5�ſ�','3�ż�');

--provider test data
INSERT  INTO Provider VALUES  ( '���������쳧001',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧002',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������003', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����004', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧005',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧006',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������007', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����008', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧009',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧010',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������011', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����012', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧013',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧014',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������015', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����016', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧017',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧018',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������019', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����020', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧021',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧022',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������023', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����024', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧025',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧026',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������027', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����028', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧029',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧030',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������031', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����032', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧033',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧034',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������035', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����036', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧037',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧038',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������039', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����040', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧041',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧042',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������043', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����044', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧045',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧046',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������047', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����048', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧049',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������050', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����051', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧052',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧053',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������054', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����055', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧056',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧057',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������058', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����059', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧060',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧061',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������062', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����063', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧064',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧065',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������066', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����067', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧068',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧069',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������070', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����071', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧072',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������073', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����074', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧075',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧076',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������077', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����078', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧079',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧080',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������081', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����082', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧083',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧084',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������085', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����086', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧087',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧088',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������089', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����090', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧091',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧092',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������093', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����094', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧095',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������096', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����097', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧098',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧099',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������100', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����101', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧102',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧103',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������104', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����105', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧106',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧107',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������108', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����109', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧110',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧111',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������112', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����113', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧114',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧115',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������116', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����117', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧118',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������119', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����120', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧121',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧122',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������123', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����124', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧125',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧126',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������127', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����128', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧129',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧130',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������131', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����132', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧133',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧134',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������135', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����136', '������', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧137',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '���������쳧138',   '����', '', '' );
INSERT  INTO Provider VALUES  ( '������������139', '������', '', '' );
INSERT  INTO Provider VALUES  ( '�����о�����140', '������', '', '' );
