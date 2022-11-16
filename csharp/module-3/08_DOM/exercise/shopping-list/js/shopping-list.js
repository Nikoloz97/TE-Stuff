// add pageTitle

const pageTitle = "My Shopping List";

// add groceries

const groceries = ['apples', 'oranges', 'broccoli', 'tacos', 'pears', 'blueberries', 'beans', 'tortilla', 'yogurt', 'eggs'];

/**
 * This function will get a reference to the title and set its text to the value
 * of the pageTitle variable that was set above.
 */
function setPageTitle() {
  const pageTitleHeader = document.querySelector('#title');
  pageTitleHeader.innerText = pageTitle;
}

/**
 * This function will loop over the array of groceries that was set above and add them to the DOM.
 */
function displayGroceries() {
  const pageUnorderedList = document.querySelector('#groceries');
  groceries.forEach((groceryItem) => {
    const listItem = document.createElement('li');
    pageUnorderedList.insertAdjacentElement('beforeend', listItem);
    listItem.innerText = groceryItem;
  })


}

/**
 * This function will be called when the button is clicked. You will need to get a reference
 * to every list item and add the class completed to each one
 */
function markCompleted() {
  const unorderedList = document.querySelector('#groceries');
  const listItems = unorderedList.children;
  const listItemsArray = Array.from(listItems);
  listItemsArray.forEach((listItem) => {
    listItem.classList.add('completed');
  })

}

setPageTitle();

displayGroceries();

// Don't worry too much about what is going on here, we will cover this when we discuss events.
document.addEventListener('DOMContentLoaded', () => {
  // When the DOM Content has loaded attach a click listener to the button
  const button = document.querySelector('.btn');
  button.addEventListener('click', markCompleted);
});
