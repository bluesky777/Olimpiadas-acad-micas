UPDATE tbDetalleExamen set DetTiempo =  abs(checksum(newid())) % 100