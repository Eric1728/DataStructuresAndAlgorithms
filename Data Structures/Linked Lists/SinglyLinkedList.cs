public class SinglyLinkedListNode<T>
{
    public T Data { get; set; }

    public SinglyLinkedListNode Next { get; set; }

    public SinglyLinkedListNode(T data)
    {
        Data = data;
    }
}

public class SinglyLinkedList<T>
{
    private int _count = 0;
    private SinglyLinkedListNode<T> _head;

    public bool IsEmpty
    {
        get { return _count == 0; }
    }

    public int Size
    {
        get { return _count; }
    }

    public void Add(T data)
    {
        if (IsEmpty())
        {
            _head = node;
        }
        else
        {
            AddLast(data);
        }
    }

    public void AddFirst(T data)
    {
        SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>();
        node.Data = data;

        if (IsEmpty())
        {
            _head = node;
        }
        else
        {
            node.Next = _head;
            _head = node;
        }

        _count++;
    }

    public void AddLast(T data)
    {
        SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>();
        node.Data = data;

        SinglyLinkedListNode<T> current = new SinglyLinkedListNode<T>();
        current = _head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = node;

        _count++;
    }

    public void Remove(T data)
    {
        SinglyLinkedListNode current = new SinglyLinkedListNode();
        SinglyLinkedListNode prev = new SinglyLinkedListNode();

        current = _head;

        if (current != null && current.Data == data)
        {
            _head = current.Next;
            _count--;
        }

        while (current != null && current.Data != data)
        {
            prev = current;
            current = current.Next;
        }

        if (current == null) return;

        prev.Next == current.Next;
        _count--;
    }
}