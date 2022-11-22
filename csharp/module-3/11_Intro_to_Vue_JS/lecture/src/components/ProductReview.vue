<template>
<div class="main">
    <h1>{{title}}</h1>
    <p>{{description}}</p>
    <div class="well-display">
    <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        Average Rating: {{averageRating}}
    </div>
    <div class="well">
        <span class="amount">{{numberOfOne}}</span>
        1 Star Review{{numberOfOne === 1 ? '' : 's'}}
    </div>
    <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        2 Star Review
    </div>
    <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        3 Star Review
    </div>
    <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        4 Star Review
    </div>
    <div class="well">
        <span class="amount"><!-- data binding goes here --></span>
        5 Star Review
    </div>
</div>
    <!-- For each item in reviews array, throw this div on there... -->
    <!-- v-bind:key = almost always same name as our item -->
    <div class="review" v-bind:class = "{ favorited:review.favorite }"
    v-for="review in reviews" v-bind:key ="review">
        <h4>Reviewer Name</h4>
        <div class="rating">
            <!-- Iterate through rating value, and as we count to it, add this star image -->
            <!-- E.g. rating: 3 = 1, 2, 3... (adds a star each time) -->
            <img class = "ratingStar" src="../assets/star.png" alt=""
             v-for= "number in review.rating" v-bind:key ="number">
        </div>
        <h3>{{review.title}}</h3>
        <p>{{review.content}}</p>
        <p>Favorite? <input type="checkbox" v-model="review.favorite"></p>
    </div>
</div>
  
</template>

<script>
export default {
    name: 'product-review',

// **Why does everything have to be in data function? Where is this being called
    data() {
        return {
            title: 'Product Reviews',
            description: 'Host and plan...',
             reviews: [
  {
    reviewer: 'Malcolm Madwell',
    title: 'What a book!',
    review:
    "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language. Yes indeed, it is a book!",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
]

        }
    },

    computed: {
    averageRating() {
        let ratingSum = this.reviews.reduce((sum, nextReview) => {return sum + nextReview.rating}, 0);
        let numbOfReviews = this.reviews.length;
        return ratingSum/numbOfReviews;
    },
    numberOfOne() {
        let oneStarReviews = this.reviews.filter ((review) => {
            return review.rating == 1;
        })
        return oneStarReviews.length;
    }
    }
}
   

</script>

<style>

div.main div.well-display {
    display: flex;
    justify-content: space-around;
}
div.main div.well-display div.well {
    display: inline-block;
    width: 15%;
    border: 1px black solid;
    border-radius: 6px;
    text-align: center;
    margin: 0.25rem;
}
div.main div.well-display div.well span.amount {
    color: darkslategray;
    display: block;
    font-size: 2.5rem;
}
div.main div.review {
    border: 1px black solid;
    border-radius: 6px;
    padding: 1rem;
    margin: 10px;
}
div.main div.review div.rating {
    height: 2rem;
    display: inline-block;
    vertical-align: top;
    margin: 0 0.5rem;
}
div.main div.review div.rating img {
    height: 100%;
}
div.main div.review p {
    margin: 20px;
}
div.main div.review h3 {
    display: inline-block;
}
div.main div.review h4 {
    font-size: 1rem;
}

div.main div.review.favorited {
    background-color: brown;
}
</style>