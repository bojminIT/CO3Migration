Public Class ObjectTypeParentChildRelationShip
    Public parentObjectTypeId, objectTypeId As Integer
    Public parentObjectType, objectType As String

    Public Sub New(parObjTypeId As Integer, parObjType As String, objTypeId As Integer, objType As String)
        parentObjectTypeId = parObjTypeId
        parentObjectType = parObjType
        objectTypeId = objTypeId
        objectType = objType
    End Sub
End Class
