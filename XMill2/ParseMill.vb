Imports System.Xml

Public Class ParseMill
    Public ListOfObjTypes As List(Of ObjectTypeParentChildRelationShip)
    Public XmlDoc As XmlDocument ' Load XML
    Public ListOfNodeNames As List(Of String)
    Public Sub New()
        ListOfObjTypes = New List(Of ObjectTypeParentChildRelationShip)
        ListOfNodeNames = New List(Of String)
        XmlDoc = New XmlDocument()
    End Sub
    Public Function testNodeExists(list As List(Of String), compare As String) As Boolean
        For Each item As String In list
            If item.Equals(compare) Then
                'MessageBox.Show(item + " and " + compare + " are same")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function testIfObjectTypeExist(list As List(Of ObjectTypeParentChildRelationShip), compareObjectTypeId As String, compareObjectType As String) As Boolean
        For Each item As ObjectTypeParentChildRelationShip In list
            If item.objectTypeId.Equals(compareObjectTypeId) And item.objectType.Equals(compareObjectType) Then
                'MessageBox.Show(item + " and " + compare + " are same")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function returnObjectType(existingObjTypeList As List(Of ObjectTypeParentChildRelationShip), compareObjTypeId As String) As ObjectTypeParentChildRelationShip
        For Each item As ObjectTypeParentChildRelationShip In existingObjTypeList
            If item.objectTypeId.ToString().Equals(compareObjTypeId.ToString()) Then
                Dim ot As ObjectTypeParentChildRelationShip = New ObjectTypeParentChildRelationShip(item.parentObjectTypeId, item.parentObjectType, item.objectTypeId, item.objectType)
                Return ot
            End If
        Next
        Return New ObjectTypeParentChildRelationShip(DBNull.Value.ToString(), DBNull.Value.ToString(), DBNull.Value.ToString(), DBNull.Value.ToString())
    End Function

    Sub ReadNodes(filePath As String, dt_parsePreview As DataTable, ListOfNodeNames As List(Of String), xmlFileName As String)

        Dim objectNodes As XmlNodeList = XmlDoc.DocumentElement.SelectNodes(filePath)
        Dim valueOfTheInnerText, objectTypeName, nameOfTheNode, objectTypeWhenNodeHasNoAtt, nodeNameDoesNotHaveAtt, nodeNameHasObjectTypeId As String
        Dim objectTypeId, bvId, objectTypeIdWhenNodeHasNoAtt, testCounter As Integer

        objectTypeId = objectNodes.ItemOf(0).Attributes("object_type_id").Value ' this is id of objecty type
        objectTypeName = objectNodes.Item(0).Name.ToString() ' get name of the object type 
        testCounter = 0
        Dim currenFilePath As String = filePath.ToString()

        For Each xmlnode As XmlNode In objectNodes
            testCounter = xmlnode.ChildNodes.Count
        Next

        testCounter = testCounter - 1 ' counter-- as index starts from 0
        Dim otpcrs As ObjectTypeParentChildRelationShip
        For Each node As XmlNode In objectNodes

            otpcrs = returnObjectType(ListOfObjTypes, objectTypeId)

            dt_parsePreview.Rows.Add(xmlFileName, otpcrs.parentObjectTypeId, otpcrs.parentObjectType, otpcrs.objectTypeId, otpcrs.objectType, DBNull.Value, DBNull.Value, DBNull.Value, DateTime.Now.ToString("yyyyMMddhhmmssMM"))

            For index = 0 To testCounter
                nameOfTheNode = node.ChildNodes.Item(index).Name.ToString() ' this is name of the bv node
                valueOfTheInnerText = node.SelectSingleNode(nameOfTheNode).InnerText.ToString() ' this is value of that bv node

                If valueOfTheInnerText.Equals("") Then ' if node is blank/empty put value -1
                    valueOfTheInnerText = "-1"
                End If

                If node.SelectSingleNode(nameOfTheNode).Attributes("object_type_id") Is Nothing And node.SelectSingleNode(nameOfTheNode).Attributes("bv_id") Is Nothing Then ' if node does not have attribute
                    objectTypeWhenNodeHasNoAtt = node.SelectSingleNode(nameOfTheNode).ChildNodes.Item(0).Name.ToString()      ' it's is used only when node does not have att, then user need to take child that has attr.
                    objectTypeIdWhenNodeHasNoAtt = node.SelectSingleNode(nameOfTheNode).ChildNodes.Item(0).Attributes("object_type_id").Value
                    nodeNameDoesNotHaveAtt = currenFilePath + "/" + nameOfTheNode + "/" + objectTypeWhenNodeHasNoAtt.ToString()
                    If testNodeExists(ListOfNodeNames, nodeNameDoesNotHaveAtt) Then
                    Else
                        ListOfNodeNames.Add(nodeNameDoesNotHaveAtt)
                        ReadNodes(nodeNameDoesNotHaveAtt, dt_parsePreview, ListOfNodeNames, xmlFileName)
                    End If
                Else                                                                                                                                            ' if this is BV
                    If node.SelectSingleNode(nameOfTheNode).Attributes("object_type_id") Is Nothing Then
                        bvId = node.SelectSingleNode(nameOfTheNode).Attributes("bv_id").Value
                        dt_parsePreview.Rows.Add(xmlFileName, DBNull.Value, DBNull.Value, objectTypeId, objectTypeName, bvId, valueOfTheInnerText, nameOfTheNode, DateTime.Now.ToString("yyyyMMddhhmmssMM"))
                    Else                                                                                                                                            ' If this is OBJECT TYPE
                        bvId = node.SelectSingleNode(nameOfTheNode).Attributes("object_type_id").Value.ToString()
                        nodeNameHasObjectTypeId = currenFilePath + "/" + nameOfTheNode.ToString()

                        If testNodeExists(ListOfNodeNames, nodeNameHasObjectTypeId) Then
                            'MessageBox("skip duplicates")
                        Else
                            ListOfNodeNames.Add(nodeNameHasObjectTypeId)
                            ReadNodes(nodeNameHasObjectTypeId, dt_parsePreview, ListOfNodeNames, xmlFileName)
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Sub CreateObjectTypeList(filePath As String, ListOfObjectTypesNames As List(Of ObjectTypeParentChildRelationShip), xmlFileName As String)
        Dim objectNodes As XmlNodeList = XmlDoc.DocumentElement.SelectNodes(filePath)
        Dim valueOfTheInnerText, objectTypeName, nameOfTheNode, objectTypeWhenNodeHasNoAtt As String
        Dim objectTypeId, bvId, objectTypeIdWhenNodeHasNoAtt, testCounter As Integer
        Dim nodeNameDoesNotHaveAtt, nodeNameHasObjectTypeId As String
        objectTypeId = objectNodes.ItemOf(0).Attributes("object_type_id").Value ' this is id of objecty type
        objectTypeName = objectNodes.Item(0).Name.ToString() ' get name of the object type 
        testCounter = 0
        Dim printTestNode As String = filePath.ToString()

        For Each xmlnode As XmlNode In objectNodes
            testCounter = xmlnode.ChildNodes.Count
        Next

        testCounter = testCounter - 1 ' counter-- as index starts from 0

        For Each node As XmlNode In objectNodes
            For index = 0 To testCounter
                nameOfTheNode = node.ChildNodes.Item(index).Name.ToString() ' this is name of the bv node
                valueOfTheInnerText = node.SelectSingleNode(nameOfTheNode).InnerText.ToString() ' this is value of that bv node
                If node.SelectSingleNode(nameOfTheNode).Attributes("object_type_id") Is Nothing And node.SelectSingleNode(nameOfTheNode).Attributes("bv_id") Is Nothing Then ' if node does not have attribute
                    objectTypeWhenNodeHasNoAtt = node.SelectSingleNode(nameOfTheNode).ChildNodes.Item(0).Name.ToString()      ' it's is used only when node does not have att, then user need to take child that has attr.
                    objectTypeIdWhenNodeHasNoAtt = node.SelectSingleNode(nameOfTheNode).ChildNodes.Item(0).Attributes("object_type_id").Value
                    nodeNameDoesNotHaveAtt = printTestNode + "/" + nameOfTheNode + "/" + objectTypeWhenNodeHasNoAtt.ToString()
                    If testIfObjectTypeExist(ListOfObjectTypesNames, objectTypeIdWhenNodeHasNoAtt.ToString(), objectTypeWhenNodeHasNoAtt) Then
                        'MessageBox("skip duplicates")
                    Else
                        ListOfObjectTypesNames.Add(New ObjectTypeParentChildRelationShip(objectTypeId.ToString(), objectTypeName, objectTypeIdWhenNodeHasNoAtt.ToString(), objectTypeWhenNodeHasNoAtt))
                        CreateObjectTypeList(nodeNameDoesNotHaveAtt, ListOfObjectTypesNames, xmlFileName)
                    End If
                Else                                                                                                                                            ' if this is BV
                    If node.SelectSingleNode(nameOfTheNode).Attributes("object_type_id") Is Nothing Then
                        bvId = node.SelectSingleNode(nameOfTheNode).Attributes("bv_id").Value
                    Else                                                                                                                                            ' If this is OBJECT TYPE
                        bvId = node.SelectSingleNode(nameOfTheNode).Attributes("object_type_id").Value.ToString()
                        nodeNameHasObjectTypeId = printTestNode + "/" + nameOfTheNode.ToString()
                        If testIfObjectTypeExist(ListOfObjectTypesNames, bvId.ToString(), nameOfTheNode) Then
                            'MessageBox("skip duplicates")
                        Else
                            ListOfObjectTypesNames.Add(New ObjectTypeParentChildRelationShip(objectTypeId.ToString(), objectTypeName, bvId.ToString(), nameOfTheNode))
                            CreateObjectTypeList(nodeNameHasObjectTypeId, ListOfObjectTypesNames, xmlFileName)
                        End If
                    End If
                End If
            Next
        Next
    End Sub
End Class
