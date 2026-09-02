Imports System
Module gestor_de_calificaciones
    Sub Main(args As String())
        Dim ids(19) As Integer
        Dim nombres(19) As String
        Dim documentos(19) As String
        Dim asignaturas(19) As String
        Dim calificacion1(19) As Double
        Dim calificacion2(19) As Double
        Dim calificacion3(19) As Double
        Dim promedios(19) As Double
        Dim estados(19) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '---------------------------------------------'
        '--|menu_principal_gestor_de_calificaciones|--'
        '---------------------------------------------'
        Do
            Console.WriteLine("menu principal gestor de calificaciones")
            Console.WriteLine("1) Registrar calificacion")
            Console.WriteLine("2) Editar calificacion")
            Console.WriteLine("3) Listar calificaciones")
            Console.WriteLine("4) Buscar calificacion")
            Console.WriteLine("5) Eliminar calificacion")
            Console.WriteLine("6) Calcular promedios")
            Console.WriteLine("7) Mostrar resumen")
            Console.WriteLine("8) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '----------------------------'
                '--|registrar_calificacion|--'
                '----------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas calificaciones.")
                    Else
                        Console.Write("Ingrese el nombre del estudiante: ")
                        Dim nuevoNombre As String = Console.ReadLine()
                        If nuevoNombre = "" Then
                            Console.WriteLine("El nombre no puede estar vacio.")
                        Else
                            Console.Write("Ingrese el documento: ")
                            Dim nuevoDocumento As String = Console.ReadLine()
                            If nuevoDocumento = "" Then
                                Console.WriteLine("El documento no puede estar vacio.")
                            Else
                                Dim documentoExiste As Boolean = False
                                For i As Integer = 0 To cantidad - 1
                                    If documentos(i).ToLower() = nuevoDocumento.ToLower() Then
                                        documentoExiste = True
                                    End If
                                Next
                                If documentoExiste Then
                                    Console.WriteLine("No se puede registrar. El documento ya existe.")
                                Else
                                    Console.Write("Ingrese la asignatura: ")
                                    Dim nuevaAsignatura As String = Console.ReadLine()
                                    If nuevaAsignatura = "" Then
                                        Console.WriteLine("La asignatura no puede estar vacia.")
                                    Else
                                        Console.Write("Ingrese la calificacion 1: ")
                                        Dim nuevaCalificacion1 As Double = Convert.ToDouble(Console.ReadLine())
                                        If nuevaCalificacion1 < 0 OrElse nuevaCalificacion1 > 5 Then
                                            Console.WriteLine("La calificacion debe estar entre 0 y 5.")
                                        Else
                                            Console.Write("Ingrese la calificacion 2: ")
                                            Dim nuevaCalificacion2 As Double = Convert.ToDouble(Console.ReadLine())
                                            If nuevaCalificacion2 < 0 OrElse nuevaCalificacion2 > 5 Then
                                                Console.WriteLine("La calificacion debe estar entre 0 y 5.")
                                            Else
                                                Console.Write("Ingrese la calificacion 3: ")
                                                Dim nuevaCalificacion3 As Double = Convert.ToDouble(Console.ReadLine())
                                                If nuevaCalificacion3 < 0 OrElse nuevaCalificacion3 > 5 Then
                                                    Console.WriteLine("La calificacion debe estar entre 0 y 5.")
                                                Else
                                                    Dim nuevoPromedio As Double = (nuevaCalificacion1 + nuevaCalificacion2 + nuevaCalificacion3) / 3
                                                    Dim nuevoEstado As String = ""
                                                    If nuevoPromedio >= 3 Then
                                                        nuevoEstado = "Aprobado"
                                                    Else
                                                        nuevoEstado = "Reprobado"
                                                    End If
                                                    ids(cantidad) = cantidad + 1
                                                    nombres(cantidad) = nuevoNombre
                                                    documentos(cantidad) = nuevoDocumento
                                                    asignaturas(cantidad) = nuevaAsignatura
                                                    calificacion1(cantidad) = nuevaCalificacion1
                                                    calificacion2(cantidad) = nuevaCalificacion2
                                                    calificacion3(cantidad) = nuevaCalificacion3
                                                    promedios(cantidad) = nuevoPromedio
                                                    estados(cantidad) = nuevoEstado
                                                    cantidad += 1
                                                    Console.WriteLine("Calificacion registrada correctamente.")
                                                    Console.WriteLine("ID: " & ids(cantidad - 1) & " | Nombre: " & nombres(cantidad - 1) & " | Documento: " & documentos(cantidad - 1) & " | Asignatura: " & asignaturas(cantidad - 1) & " | Calificacion 1: " & calificacion1(cantidad - 1).ToString("N2") & " | Calificacion 2: " & calificacion2(cantidad - 1).ToString("N2") & " | Calificacion 3: " & calificacion3(cantidad - 1).ToString("N2") & " | Promedio: " & promedios(cantidad - 1).ToString("N2") & " | Estado: " & estados(cantidad - 1))
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                '-------------------------'
                '--|editar_calificacion|--'
                '-------------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen calificaciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la calificacion a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 AndAlso idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            Dim nuevoNombre As String = Console.ReadLine()
                            If nuevoNombre = "" Then
                                Console.WriteLine("El nombre no puede estar vacio.")
                            Else
                                nombres(posicion) = nuevoNombre
                                Console.Write("Nuevo documento: ")
                                Dim nuevoDocumento As String = Console.ReadLine()
                                If nuevoDocumento = "" Then
                                    Console.WriteLine("El documento no puede estar vacio.")
                                Else
                                    documentos(posicion) = nuevoDocumento
                                    Console.Write("Nueva asignatura: ")
                                    Dim nuevaAsignatura As String = Console.ReadLine()
                                    If nuevaAsignatura = "" Then
                                        Console.WriteLine("La asignatura no puede estar vacia.")
                                    Else
                                        asignaturas(posicion) = nuevaAsignatura
                                        Console.Write("Nueva calificacion 1: ")
                                        Dim nuevaCalificacion1 As Double = Convert.ToDouble(Console.ReadLine())
                                        If nuevaCalificacion1 < 0 OrElse nuevaCalificacion1 > 5 Then
                                            Console.WriteLine("La calificacion debe estar entre 0 y 5.")
                                        Else
                                            Console.Write("Nueva calificacion 2: ")
                                            Dim nuevaCalificacion2 As Double = Convert.ToDouble(Console.ReadLine())
                                            If nuevaCalificacion2 < 0 OrElse nuevaCalificacion2 > 5 Then
                                                Console.WriteLine("La calificacion debe estar entre 0 y 5.")
                                            Else
                                                Console.Write("Nueva calificacion 3: ")
                                                Dim nuevaCalificacion3 As Double = Convert.ToDouble(Console.ReadLine())
                                                If nuevaCalificacion3 < 0 OrElse nuevaCalificacion3 > 5 Then
                                                    Console.WriteLine("La calificacion debe estar entre 0 y 5.")
                                                Else
                                                    calificacion1(posicion) = nuevaCalificacion1
                                                    calificacion2(posicion) = nuevaCalificacion2
                                                    calificacion3(posicion) = nuevaCalificacion3
                                                    promedios(posicion) = (nuevaCalificacion1 + nuevaCalificacion2 + nuevaCalificacion3) / 3
                                                    If promedios(posicion) >= 3 Then
                                                        estados(posicion) = "Aprobado"
                                                    Else
                                                        estados(posicion) = "Reprobado"
                                                    End If
                                                    Console.WriteLine("Calificacion actualizada correctamente.")
                                                    Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Documento: " & documentos(posicion) & " | Asignatura: " & asignaturas(posicion) & " | Calificacion 1: " & calificacion1(posicion).ToString("N2") & " | Calificacion 2: " & calificacion2(posicion).ToString("N2") & " | Calificacion 3: " & calificacion3(posicion).ToString("N2") & " | Promedio: " & promedios(posicion).ToString("N2") & " | Estado: " & estados(posicion))
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------------'
                '--|listar_calificaciones|--'
                '---------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen calificaciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                        Next
                    End If
                '-------------------------'
                '--|buscar_calificacion|--'
                '-------------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen calificaciones registradas.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por nombre")
                        Console.WriteLine("3) Buscar por documento")
                        Console.WriteLine("4) Buscar por asignatura")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 AndAlso idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Documento: " & documentos(posicion) & " | Asignatura: " & asignaturas(posicion) & " | Calificacion 1: " & calificacion1(posicion).ToString("N2") & " | Calificacion 2: " & calificacion2(posicion).ToString("N2") & " | Calificacion 3: " & calificacion3(posicion).ToString("N2") & " | Promedio: " & promedios(posicion).ToString("N2") & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el nombre: ")
                            Dim nombreBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If nombres(i).ToLower().Contains(nombreBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron calificaciones.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese el documento: ")
                            Dim documentoBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If documentos(i).ToLower().Contains(documentoBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron calificaciones.")
                            End If
                        ElseIf tipoBusqueda = 4 Then
                            Console.Write("Ingrese la asignatura: ")
                            Dim asignaturaBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If asignaturas(i).ToLower().Contains(asignaturaBuscar.ToLower()) Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron calificaciones en esa asignatura.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '---------------------------'
                '--|eliminar_calificacion|--'
                '---------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen calificaciones registradas.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID de la calificacion a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 AndAlso idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                documentos(i) = documentos(i + 1)
                                asignaturas(i) = asignaturas(i + 1)
                                calificacion1(i) = calificacion1(i + 1)
                                calificacion2(i) = calificacion2(i + 1)
                                calificacion3(i) = calificacion3(i + 1)
                                promedios(i) = promedios(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            nombres(cantidad) = ""
                            documentos(cantidad) = ""
                            asignaturas(cantidad) = ""
                            calificacion1(cantidad) = 0
                            calificacion2(cantidad) = 0
                            calificacion3(cantidad) = 0
                            promedios(cantidad) = 0
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Calificacion eliminada correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------'
                '--|calcular_promedios|--'
                '------------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen calificaciones registradas.")
                    Else
                        Console.WriteLine("1) Mostrar promedio de todos")
                        Console.WriteLine("2) Mostrar mayor promedio")
                        Console.WriteLine("3) Mostrar menor promedio")
                        Console.WriteLine("4) Mostrar aprobados")
                        Console.WriteLine("5) Mostrar reprobados")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoCalculo As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoCalculo = 1 Then
                            For i As Integer = 0 To cantidad - 1
                                Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Asignatura: " & asignaturas(i) & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                            Next
                        ElseIf tipoCalculo = 2 Then
                            Dim mayorPromedio As Double = promedios(0)
                            Dim posicionMayor As Integer = 0
                            For i As Integer = 1 To cantidad - 1
                                If promedios(i) > mayorPromedio Then
                                    mayorPromedio = promedios(i)
                                    posicionMayor = i
                                End If
                            Next
                            Console.WriteLine("Mayor promedio: " & mayorPromedio.ToString("N2"))
                            Console.WriteLine("ID: " & ids(posicionMayor) & " | Nombre: " & nombres(posicionMayor) & " | Documento: " & documentos(posicionMayor) & " | Asignatura: " & asignaturas(posicionMayor) & " | Promedio: " & promedios(posicionMayor).ToString("N2") & " | Estado: " & estados(posicionMayor))
                        ElseIf tipoCalculo = 3 Then
                            Dim menorPromedio As Double = promedios(0)
                            Dim posicionMenor As Integer = 0
                            For i As Integer = 1 To cantidad - 1
                                If promedios(i) < menorPromedio Then
                                    menorPromedio = promedios(i)
                                    posicionMenor = i
                                End If
                            Next
                            Console.WriteLine("Menor promedio: " & menorPromedio.ToString("N2"))
                            Console.WriteLine("ID: " & ids(posicionMenor) & " | Nombre: " & nombres(posicionMenor) & " | Documento: " & documentos(posicionMenor) & " | Asignatura: " & asignaturas(posicionMenor) & " | Promedio: " & promedios(posicionMenor).ToString("N2") & " | Estado: " & estados(posicionMenor))
                        ElseIf tipoCalculo = 4 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If estados(i) = "Aprobado" Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen estudiantes aprobados.")
                            End If
                        ElseIf tipoCalculo = 5 Then
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If estados(i) = "Reprobado" Then
                                    Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Documento: " & documentos(i) & " | Asignatura: " & asignaturas(i) & " | Calificacion 1: " & calificacion1(i).ToString("N2") & " | Calificacion 2: " & calificacion2(i).ToString("N2") & " | Calificacion 3: " & calificacion3(i).ToString("N2") & " | Promedio: " & promedios(i).ToString("N2") & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No existen estudiantes reprobados.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 7
                    If cantidad = 0 Then
                        Console.WriteLine("No existen calificaciones registradas.")
                    Else
                        Dim aprobados As Integer = 0
                        Dim reprobados As Integer = 0
                        Dim sumaPromedios As Double = 0
                        Dim mayorPromedio As Double = promedios(0)
                        Dim menorPromedio As Double = promedios(0)
                        For i As Integer = 0 To cantidad - 1
                            sumaPromedios += promedios(i)
                            If estados(i) = "Aprobado" Then
                                aprobados += 1
                            ElseIf estados(i) = "Reprobado" Then
                                reprobados += 1
                            End If
                            If promedios(i) > mayorPromedio Then
                                mayorPromedio = promedios(i)
                            End If
                            If promedios(i) < menorPromedio Then
                                menorPromedio = promedios(i)
                            End If
                        Next
                        Dim promedioGeneral As Double = sumaPromedios / cantidad
                        Console.WriteLine("Total de calificaciones: " & cantidad)
                        Console.WriteLine("Estudiantes aprobados: " & aprobados)
                        Console.WriteLine("Estudiantes reprobados: " & reprobados)
                        Console.WriteLine("Promedio general: " & promedioGeneral.ToString("N2"))
                        Console.WriteLine("Mayor promedio: " & mayorPromedio.ToString("N2"))
                        Console.WriteLine("Menor promedio: " & menorPromedio.ToString("N2"))
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 8
                    Console.WriteLine("Gracias por utilizar Gestor de Calificaciones.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 8
    End Sub
End Module