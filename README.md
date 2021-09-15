# Product API
CRUD Básico de productos

## Obtener Lista de Productos

### Request
 
`GET /api/Product`

### Response

    {
      Data : Producto[]
    }

## Obtener Producto Específico

### Request
 
`GET /api/Product/{id}`

### Response

    {
      Data : Producto
    }
    
## Crear Producto

### Request
 
`POST /api/Product`

Ejemplo de Body JSON:

    {
      "idMarca": 0,
      "idPresentacion": 0,
      "idProveedor": 0,
      "idZona": 0,
      "codigo": 000,
      "descripcionProducto": "Example",
      "precio": 0.00,
      "stock": 0,
      "iva": null,
      "peso": null
    }

### Response

    {
      Data : Producto
    }

## Actualizar Producto

### Request
 
`PUT /api/Product?id=0`

Ejemplo de Body JSON:

    {
      "codigo": 000,
      "descripcionProducto": "Example",
      "precio": 0.00,
      "stock": 0,
      "iva": null,
      "peso": null
    }

### Response

    {
      Data : true | false
    }

## Eliminar Producto

### Request
 
`DELETE /api/Product/{id}`

### Response

    {
      Data : true | false
    }
