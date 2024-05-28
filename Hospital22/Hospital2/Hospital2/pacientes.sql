CREATE TABLE pacientes (
  rut_paciente varchar(15) NOT NULL,
  nombre_paciente varchar(20) DEFAULT NULL,
  apellido_paciente varchar(40) DEFAULT NULL,
  direccion_paciente varchar(50) DEFAULT NULL,
  fecha_nacimiento date DEFAULT NULL,
  fono_paciente varchar(15) DEFAULT NULL
  )