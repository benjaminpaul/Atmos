<template>
    <div class="call-to-action animate__animated animate__pulse animate__delay-2s animate__infinite">
        <p>{{text}}</p>
        <div class="arrow"></div>
    </div>
</template>

<script>
    export default {
        name: "CallToAction",
        props: {
            text: String
        }
    }
</script>

<style scoped>
    .call-to-action {
        text-align: center;
        margin-bottom: 1em;
    }
    .call-to-action > p {
        padding: 0;
        margin: 0;
        display: inline-block;
        position: relative;
        padding: 0;
        padding: 1em;
        padding-left: 3em;
        padding-right: 3em;
        background-color: #437DB0;
        margin-bottom: 2em;
        border-radius: 10px;
        font-weight: normal;
        font-size: 14px;
        z-index: 1000;
    }
    .call-to-action > .arrow {
        background-color: #437DB0;
        width: 30px;
        position: absolute;
        height: 30px;
        left: 0;
        right: 0;
        margin-left: auto;
        margin-right: auto;
        bottom: 23px;
        display: inline-block;
        transform: rotate(45deg);
    }
</style>