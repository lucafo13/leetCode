function addTwoNumbers(l1: ListNode | null, l2: ListNode | null): ListNode | null {
    const dummyHead = new ListNode(0);
    let atual = dummyHead;
    let carry = 0;

    while (l1 !== null || l2 !== null || carry > 0) {
        const val1 = l1 !== null ? l1.val : 0;
        const val2 = l2 !== null ? l2.val : 0;

        const somaTotal = val1 + val2 + carry;
        
        carry = Math.floor(somaTotal / 10);
        const novoDigito = somaTotal % 10;

        atual.next = new ListNode(novoDigito);
        atual = atual.next;

        if (l1 !== null) l1 = l1.next;
        if (l2 !== null) l2 = l2.next;
    }

    return dummyHead.next;
}
