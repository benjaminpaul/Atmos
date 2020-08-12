<template>
    <div>
        <h2>{{title}}</h2>
        <p>{{subtitle}}</p>
        <hr/>
    </div>
</template>

<script>
    export default {
        name: "PageHeader",
        props: {
            title: String,
            subtitle: String
        }
    }
</script>

<style scoped>

</style>