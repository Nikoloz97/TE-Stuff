<template>
<div>
    <h1>Add Review</h1>
    <add-review/>

</div>
</template>

<script>
import AddReview from '../components/AddReview.vue'
export default {
    // Make sure not the same name as template element (line 4)
    name: 'add-product-review',
    components: {AddReview}

}
</script>

<style>

</style>