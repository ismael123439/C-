using nodoss;

public class listanodo
{
    private Nodo primero;
    private int size;
    public listanodo()
    {
        primero = null;
        size = 0;
    }
    public void addNodo(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        Nodo valor1, valor2;
        if (primero == null)
        {
            primero = nuevo;
            nuevo.siguiente = null;
        }
        else
        {
            valor1 = primero;
            while (valor1 != null)
            {
                valor2 = primero.siguiente;
            }
        }

    }
}