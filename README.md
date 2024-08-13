# Helpful Operations for Completing the Collections Master Console UI Exercise

## 1. **Using `Array.Reverse()`**

The `Array.Reverse()` method is used to reverse the elements of an array in place.

### Example:
```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
Array.Reverse(numbers);

// The array `numbers` now contains: { 5, 4, 3, 2, 1 }
```

### How to Use:

Call `Array.Reverse(arrayName)` where `arrayName` is the array you want to reverse.

---

## 2. **Clearing a List**

The `List<T>.Clear()` method removes all elements from the list, making it empty.

### Example:
```csharp
List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
numberList.Clear();

// The list `numberList` is now empty
```
### How to Use:


Call `listName.Clear()` where `listName` is the list you want to clear.

---

## 3. **Checking the Capacity of a List**
The List<T>.Capacity property returns the number of elements that the list can hold before needing to resize.

### Example:
```csharp
List<int> numberList = new List<int> { 1, 2, 3 };
int capacity = numberList.Capacity;

// `capacity` will contain the current capacity of `numberList`
```

### How to Use:
Access `listName.Capacity` where `listName` is the list whose capacity you want to check.

---

## 4. **Sorting an Array or List**
Sorting an Array:
To sort an array, you can use the Array.Sort() method.

### Example:
```csharp
int[] numbers = { 5, 3, 8, 1, 2 };
Array.Sort(numbers);

// The array `numbers` is now sorted: { 1, 2, 3, 5, 8 }
```
Sorting a List:
To sort a list, you can use the List<T>.Sort() method.

### Example:
```csharp
List<int> numberList = new List<int> { 5, 3, 8, 1, 2 };
numberList.Sort();

// The list `numberList` is now sorted: { 1, 2, 3, 5, 8 }
```
### How to Use:
Call `Array.Sort(arrayName)` for arrays or `listName.Sort()` for lists.

---

## 5. **Converting a List to an Array**
You can convert a list to an array using the `List<T>.ToArray()` method.

### Example:
```csharp
List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };
int[] numberArray = numberList.ToArray();

// `numberArray` now contains the elements of `numberList` as an array
```
### How to Use:
Call `listName.ToArray()` to convert the list to an array.

---

## 6. **Removing Odd Numbers from a List**
To remove odd numbers from a list, you can loop through the list and remove each odd number.

### Example:
```csharp
List<int> numberList = new List<int> { 1, 2, 3, 4, 5 };

for (int i = numberList.Count - 1; i >= 0; i--)
{
    if (numberList[i] % 2 != 0)
    {
        numberList.RemoveAt(i);
    }
}

// `numberList` now contains only even numbers: { 2, 4 }
```
### How to Use:
Use a loop to check each element, and if it's odd, remove it using `listName.RemoveAt(index)`.

---

