use SistemaNotas


alter table estudiante_materia add constraint fk_estudiante_materia foreign key (id_materia) references materia (id_materia)
alter table estudiante_materia add constraint fk_estudiante_materia1 foreign key (id_alumno) references alumnos (id_alumnos)

alter table profesor_materia add constraint fk_profesor_materia foreign key (id_profesor) references profesores (id_profesor)
alter table profesor_materia add constraint fk_profesor_materia1 foreign key (id_materia) references materia (id_materia)

alter table notas add constraint fk_nota foreign key (id_materia) references materia (id_materia)

alter table alumnos add constraint fk_grado foreign key (id_grado) references grado (id_grado)
<<<<<<< HEAD

alter table estudiante_materia add constraint fk_alumno foreign key (id_alumno) references alumnos (id_alumno)
alter table estudiante_materia add constraint fk_materia foreign key (id_materia) references materia (id_materia)

alter table notas add constraint fk_materia1 foreign key (id_materia) references materia (id_materia)

alter table profesor_materia add constraint fk_profesor foreign key (id_profesor) references profesor (id_profesor)
alter table profesor_materia add constraint fk_materia2 foreign key (id_materia1) references materia (id_materia)

=======
>>>>>>> 1632fea6c2e332392881a6551ad0868059a3b178
