--alter table REGISTRO add [proceso_registro] bit null
--Alter table REGISTRO alter column horas_laboradas decimal(10,2)
--Alter table REGISTRO alter column horas_extras decimal(10,2)
--Alter table COLABORADOR alter column precio_hora decimal(10,2)

--alter table PAGO add [bono_pago] decimal(10,2) null;
--alter table PAGO add [id_adelanto] int null;
--alter table PAGO alter column horas_laboradas_pagadas decimal(10, 2);
--alter table PAGO alter column horas_extras_pagadas decimal(10, 2);

--alter table PAGO add[proceso_pago] bit null;

--alter table PAGO add [vacaciones] decimal(10,2) null;
--alter table PAGO add [aguinaldo] decimal(10,2) null;
--alter table PAGO add [adelanto] decimal(10,2) null;
--alter table PAGO add [seguro] decimal(10,2) null;
--alter table PAGO add [id_planilla] int null;
--alter table PAGO DROP column id_adelanto;
--alter table COLABORADOR add [nombre_familiar] varchar(100) null
--alter table COLABORADOR add [tipo_planilla] int null;

--alter table HORARIO add [horas_totales] Decimal(10,2) null;

--ALTER TABLE CONFIGURACION DROP COLUMN dia_inicio;
--ALTER TABLE CONFIGURACION DROP COLUMN semana_inicio;
--ALTER TABLE CONFIGURACION ADD porcentaje_hora_extra DECIMAL(10,2);