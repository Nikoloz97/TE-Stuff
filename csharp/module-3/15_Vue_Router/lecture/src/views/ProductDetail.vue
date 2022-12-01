<template>
  <div id="app" class="main">
    <h1>{{ product.name }}</h1>
    <p class="description">{{ product.description }}</p>
    <div class="actions">
      <a href="#">Back to Products</a>&nbsp;|

      <router-link v-bind:to="{name: 'products'}"> Back to Products </router-link>

      <a href="#">Add Review</a>
    </div>
    <div class="well-display">
      <average-summary />
      <star-summary rating="1" />
      <star-summary rating="2" />
      <star-summary rating="3" />
      <star-summary rating="4" />
      <star-summary rating="5" />
    </div>
    <review-list />
  </div>
</template>

<script>

import AverageSummary from '../components/AverageSummary.vue';
import StarSummary from '../components/StarSummary.vue';
import ReviewList from '../components/ReviewList.vue';



export default {
    name: 'product-detail',
    components: {
        AverageSummary, StarSummary, ReviewList
    },

    // Goal = use getter so it always gives product with active product ID
    computed: {
        product(){
        return this.$store.getters.product
        }
    },
    // Goal = set "active product" from store -> route id
    // Created = "lifecycle hook" (runs before view displayed in DOM)
    created() {
        const activeProductId = this.$route.params.id;
        this.$store.commit('SET_ACTIVE_PRODUCT', activeProductId)
    }
}


</script>

<style>

</style>