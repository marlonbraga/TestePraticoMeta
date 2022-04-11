# Demonstração
https://wevo.marlonbraga.dev/

## Manipular diretamente API
* [GET] /api/user
* [GET] /api /user/2
* [POST] /api/user
* [PUT] /api/user/2
* [DELETE] /api/user/2
* [DELETE] /api/user

# Como fazer funcionar
É necessário trocar a string de conexão do projeto

## Criação de Tabela:
CREATE TABLE `user` (
  `ID` bigint UNSIGNED NOT NULL,
  `NAME` varchar(50) DEFAULT NULL,
  `CPF` varchar(11) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  `PHONE` varchar(20) DEFAULT NULL,
  `GENDER` int DEFAULT NULL,
  `BIRTH_DATE` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `user` (`ID`, `NAME`, `CPF`, `EMAIL`, `PHONE`, `GENDER`, `BIRTH_DATE`) VALUES
(1, 'Marlon Braga', '12174780781', 'marlon@marlonbraga.com.br', '21995009727', 1, '1991-09-28 00:00:00'),
(2, 'Bruna Alves', '12345678910', 'bruna.alves@wevo.io', '1142399200', 0, '1995-05-29 00:00:00');

ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ID` (`ID`);

ALTER TABLE `user`
  MODIFY `ID` bigint UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;
