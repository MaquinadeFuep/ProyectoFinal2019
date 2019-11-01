use SistemaNotas

alter table estudiante_materia add constraint fk_estudiante_materia foreign key (id_materia) references materias (id_materia)
alter table estudiante_materia add constraint fk_estudiante_materia1 foreign key (nie) references estudiantes (nie)
alter table profesor_materia add constraint fk_profesor_materia foreign key (id_profesor) references profesor (id_profesor)
alter table profesor_materia add constraint fk_profesor_materia1 foreign key (id_materia) references materias (id_materia)
alter table usuarios add constraint fk_estudiante_usuario foreign key (nie) references estudiantes (nie)
alter table usuarios add constraint fk_profesor_usuario foreign key (id_profesor) references profesor (id_profesor)