<template>
<div>
    <p>Title: {{book.title}}</p>
    <br>
    <p>Author: {{book.author}}</p>
    <br>
    <p>ISBN Number: {{book.isbn}}</p>
</div>
</template>

<script>
export default {
    props: 
    ["book"]
}
</script>

<style>

</style>