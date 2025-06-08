/*

   Video Project Diagram

+---------------------------+
|        Video              |
+---------------------------+
| - title: string           |
| - author: string          |
| - length: int             |
| - comments: List<Comment> |
+--------------------------------------+
| + GetNumberOfComments(): int         |
| + AddComment(comment: Comment): void |
| + DisplayInfo(): void                |
+--------------------------------------+
                |
+------------------------+
|       Comment          |
+------------------------+
| - commenter: string    |
| - text: string         |
+--------------------------+
| + GetCommenter(): string |
| + GetText(): string      |
+--------------------------+



Online ordering Project Diagram 

+---------------------------+
|            Order           |
+---------------------------+
| - customer: Customer      |
| - products: List<Product> |
+-----------------------------------+
| + CalculateTotalCost(): decimal   |
| + GeneratePackingLabel(): string  |
| + GenerateShippingLabel(): string |
+-----------------------------------+
                |
+-----------------------------+
|           Product           |
+-----------------------------+
| - name: string              |
| - productId: int            |
| - price: decimal            |
| - quantity: int             |
+-----------------------------+
| + CalculatePrice(): decimal |
+-----------------------------+
            |
+-------------------------+
|        Customer         |
+-------------------------+
| - name: string          |
| - address: Address      |
+-------------------------+
| + IsUSACustomer(): bool |
+-------------------------+
            |
+----------------------------+
|           Address          |
+----------------------------+
| - street: string           |
| - city: string             |
| - stateProvince: string    |
| - country: string          |
+----------------------------+
| + IsUSAAddress(): bool     |
| + GetFullAddress(): string |
+----------------------------+


*/