const book_name = 'Cigar Parties for Dummies';
let description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
let reviews = [
  {
    reviewer: 'Malcolm Madwell',
    title: 'What a book!',
    review:
    "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language. Yes indeed, it is a book!",
    rating: 3
  }
];

/**
 * Add product name to the page title.
 */
function setPageTitle() {
  const pageTitle = document.getElementById('page-title');
  pageTitle.querySelector('.name').innerText = book_name;
}

/**
 * Add product description to the page.
 */
function setPageDescription() {
  document.querySelector('.description').innerText = description;
}

/**
 * Display all of the reviews in the reviews array.
 */
function displayReviews() {
  if ('content' in document.createElement('template')) {
    reviews.forEach((review) => {
      displayReview(review);
    });
  } else {
    console.error('Your browser does not support templates');
  }
}

/**
 * Add single review to the page.
 *
 * @param {Object} review The review to display
 */
function displayReview(review) {
  const main = document.getElementById('main');
  const tmpl = document.getElementById('review-template').content.cloneNode(true);
  tmpl.querySelector('h4').innerText = review.reviewer;
  tmpl.querySelector('h3').innerText = review.title;
  tmpl.querySelector('p').innerText = review.review;
  // there will always be 1 star because it is a part of the template
  for (let i = 1; i < review.rating; ++i) {
    const img = tmpl.querySelector('img').cloneNode();
    tmpl.querySelector('.rating').appendChild(img);
  }
  main.appendChild(tmpl);
}

// LECTURE STARTS HERE ---------------------------------------------------------------

// Set the product reviews page title.
setPageTitle();
// Set the product reviews page description.
setPageDescription();
// Display all of the product reviews on our page.
displayReviews();


//1. Grab "target"
const descPgrph = document.querySelector('.description');
//2. "Subscribe" w/ event listener
descPgrph.addEventListener('click', toggleDescriptionEdit);
//3. Event handler
const inputDesc = document.getElementById('inputDesc');
inputDesc.addEventListener('keyup', (event) =>
{
  if (event.key === 'Enter') {
    
    exitDescriptionEdit(event.target, true)
  }


  if (event.key === 'Escape') {
    exitDescriptionEdit(event.target, false)
  }
});

// grab addReview button...
const addReviewBtn = document.getElementById('btnToggleForm');

// once clicked, toggle between addReview -> hide form -> add Review -> etc...
addReviewBtn.addEventListener('click', showHideForm);

// grab saveReview button...
const saveReviewBtn = document.getElementById('btnSaveReview');

// once clicked, add that review to 
saveReviewBtn.addEventListener('click', 
(event) => {
    // Not sure what preventDefault does??
      event.preventDefault();
      saveReview();
    });




/**
 * Hide the description and show the text box.
 *
 * @param {Element} desc the element containing the description
 */
function toggleDescriptionEdit() {
  //grab description paragraph
  const desc = document.querySelector('.description');

  // Go to next element in HTML (input)
  const textBox = desc.nextElementSibling;

  //Whatever input currently has in it = whatever was in paragraph
  textBox.value = desc.innerText;

  // d-none = default from bootstrap (gets rid of it from DOM)
  textBox.classList.remove('d-none');
  desc.classList.add('d-none');

  // add fancy blue outline over input when user clicks on it
  textBox.focus();
}

/**
 * Hide the text box and show the description.
 * If save is true, also set the description to the contents of the text box.
 *
 * @param {Element} textBox the input element containing the edited description
 * @param {Boolean} save should we save the description text
 */
function exitDescriptionEdit(textBox, save) {
  let desc = textBox.previousElementSibling;
  if (save) {
    desc.innerText = textBox.value;
  }
  textBox.classList.add('d-none');
  desc.classList.remove('d-none');
}

/**
 * Toggle visibility of the add review form.
 */
function showHideForm() {
  const form = document.querySelector('form');
  const btn = document.getElementById('btnToggleForm');

  // If add Review is clicked on -> Hide form
  if (form.classList.contains('d-none')) {
    //display the form...
    form.classList.remove('d-none');
    btn.innerText = 'Hide Form';
    document.getElementById('name').focus();
  } 

  // If Hide Form is clicked on -> back to AddReview
  else {
    resetFormValues();
    //get rid of form...
    form.classList.add('d-none');
    btn.innerText = 'Add Review';
  }
}

/**
 * Reset all of the values in the form.
 */
function resetFormValues() {
  const form = document.querySelector('form');
  const inputs = form.querySelectorAll('input');
  inputs.forEach((input) => {
    input.value = '';
  });
  document.getElementById('rating').value = 1;
  document.getElementById('review').value = '';
}

/**
 * Save the review that was added using the add review form.
 */
function saveReview() {
  let name = document.getElementById('name');
  let title = document.getElementById('title');
  let rating = document.getElementById('rating');
  let review = document.getElementById('review');

  const newReview = {
    reviewer: name.value,
    title: title.value,
    review: review.value,
    rating: rating.value
  }

  displayReview(newReview);
}
