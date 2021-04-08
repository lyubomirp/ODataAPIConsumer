export class LoaderService {

  loader: Element = document.getElementsByClassName('loader-container')[0];

  public showLoader() {
    this.loader.classList.remove('hidden');
  }

  public hideLoader() {
    this.loader.classList.add('hidden');
  }
}
