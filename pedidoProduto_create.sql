/* banco começa aqui */
create table CLIENTE
    (
      ID INT NOT NULL IDENTITY, 
      NOME varchar(200) NOT NULL,
      primary key (ID)
    );

create table PRODUTO
    (
      ID INT NOT NULL IDENTITY, 
      NOME varchar(200)NOT NULL,
      primary key (ID)
    );

create table PEDIDO 
    (
      ID INT NOT NULL IDENTITY, 
      DATAPEDIDO datetime NOT NULL,
      TOTAL real NOT NULL,
	  CLIENTE int NOT NULL,
      primary key (ID)
    );
 
create table PEDIDOPRODUTO
    (
      ID INT NOT NULL IDENTITY,  
      PEDIDO int NOT NULL,
      PRODUTO int NOT NULL,
      primary key (ID)
    );

/*
create table CLIENTEPEDIDO
    (
      ID INT NOT NULL IDENTITY, 
      PEDIDO int NOT NULL,
      CLIENTE int NOT NULL,
      primary key (ID)
    );
*/
    
/*adcionando chaves externas*/  
ALTER TABLE PEDIDO
ADD FOREIGN KEY (CLIENTE) REFERENCES CLIENTE(ID);

/*
ALTER TABLE CLIENTEPEDIDO
ADD FOREIGN KEY (PEDIDO) REFERENCES PEDIDO(ID);

ALTER TABLE CLIENTEPEDIDO
ADD FOREIGN KEY (CLIENTE) REFERENCES CLIENTE(ID);
*/

ALTER TABLE PEDIDOPRODUTO
ADD FOREIGN KEY (PEDIDOID) REFERENCES PEDIDO(ID);

ALTER TABLE PEDIDOPRODUTO
ADD FOREIGN KEY (PRODUTO) REFERENCES PRODUTO(ID);

insert into PEDIDO(DATAPEDIDO, TOTAL, CLIENTE) values ('2020-12-12 00:00:00', 4, 1);
insert into PEDIDO(DATAPEDIDO, TOTAL, CLIENTE) values ('2020-12-13 00:00:00', 5, 2);
insert into PEDIDO(DATAPEDIDO, TOTAL, CLIENTE) values ('2020-12-14 00:00:00', 6, 3);

select * from PEDIDO;
