use SistemaNotas


alter table estudiante_materia add constraint fk_estudiante_materia foreign key (id_materia) references materia (id_materia)
alter table estudiante_materia add constraint fk_estudiante_materia1 foreign key (nie) references alumnos (nie)

alter table profesor_materia add constraint fk_profesor_materia foreign key (id_profesor) references profesores (escalafon)
alter table profesor_materia add constraint fk_profesor_materia1 foreign key (id_materia) references materia (id_materia)

alter table notas add constraint fk_nota foreign key (id_materia) references materia (id_materia)
