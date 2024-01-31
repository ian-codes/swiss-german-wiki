<script>
    import Header from "$lib/components/Header.svelte";

</script>

<div class="container">
    <Header/>
    <main>
        <slot></slot>
    </main>
</div>



<style>
    .container {
        max-width: 800px;
        width: 100%;
        margin: auto;
        padding: 1em;
    }
</style>