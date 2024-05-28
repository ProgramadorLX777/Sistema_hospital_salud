ALTER TABLE doctores
ADD CONSTRAINT doctoresFK 
FOREIGN KEY (especialidad_doctor)
REFERENCES especialidad (id_especialidad);
