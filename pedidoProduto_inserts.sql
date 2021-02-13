/* adicionando elementos iniciais */
insert into CLIENTE(NOME) values ('nome cliente1');
insert into CLIENTE(NOME) values ('nome cliente2');
insert into CLIENTE(NOME) values ('nome cliente3');
insert into CLIENTE(NOME) values ('nome cliente4');
insert into CLIENTE(NOME) values ('nome cliente5');

insert into PRODUTO(NOME) values ('nome produto1');
insert into PRODUTO(NOME) values ('nome produto2');
insert into PRODUTO(NOME) values ('nome produto3');
insert into PRODUTO(NOME) values ('nome produto4');
insert into PRODUTO(NOME) values ('nome produto5');

insert into PEDIDO(DATAPEDIDO, TOTAL) values ('2020-12-12 00:00:00', 4);
insert into PEDIDO(DATAPEDIDO, TOTAL) values ('2020-12-13 00:00:00', 5);
insert into PEDIDO(DATAPEDIDO, TOTAL) values ('2020-12-14 00:00:00', 6);

insert into PEDIDOPRODUTO(PEDIDO, PRODUTO) values (1, 1);
insert into PEDIDOPRODUTO(PEDIDO, PRODUTO) values (1, 2);

insert into CLIENTEPEDIDO(PEDIDO, CLIENTE) values (1, 1);
insert into CLIENTEPEDIDO(PEDIDO, CLIENTE) values (1, 2);


