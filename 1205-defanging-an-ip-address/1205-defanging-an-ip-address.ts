function defangIPaddr(address: string): string {
    let sol = address.replaceAll(".", "[.]")
    return sol
};