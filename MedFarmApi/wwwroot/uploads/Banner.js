import React from "react";

export default function Banner() {
  return (
    <div>
      <div className="container-fluid p-0">
        <div
          id="header-carousel"
          className="carousel slide carousel-fade"
          data-bs-ride="carousel"
        >
          <div className="carousel-inner">
            <div className="carousel-item active h-100">
              <img
                className="w-100"
                style={{height:"500px"}}
                src="img/banner1.jpeg"
                alt="carousel-1"
              />
              <div className="carousel-caption top-0 bottom-0 start-0 end-0 d-flex flex-column align-items-center justify-content-center">
                <div className="text-start p-5" style={{ maxWidth: 900 }}>
                  <h3 className="text-white">Organic Vegetables</h3>
                  <h1 className="display-1 text-white mb-md-4">
                    Organic Vegetables For Healthy Life
                  </h1>
                  {/* <a href="/" className="btn btn-primary py-md-3 px-md-5 me-3">
                      Explore
                    </a>
                    <a href="/" className="btn btn-secondary py-md-3 px-md-5">
                      Contact
                    </a> */}
                </div>
              </div>
            </div>
            <div className="carousel-item">
              <img
                className="w-100"
                style={{height:"500px"}}
                src="img/banner2.jpeg"
                alt="carousel-2"
              />
              <div className="carousel-caption top-0 bottom-0 start-0 end-0 d-flex flex-column align-items-center justify-content-center">
                <div className="text-start p-5" style={{ maxWidth: 900 }}>
                  <h3 className="text-white">Organic Fruits</h3>
                  <h1 className="display-1 text-white mb-md-4">
                    Organic Fruits For Better Health
                  </h1>
                  {/* <a href="/" className="btn btn-primary py-md-3 px-md-5 me-3">
                    Explore
                  </a>
                  <a href="/" className="btn btn-secondary py-md-3 px-md-5">
                    Contact
                  </a> */}
                </div>
              </div>
            </div>
          </div>
          <button
            className="carousel-control-prev"
            type="button"
            data-bs-target="#header-carousel"
            data-bs-slide="prev"
          >
            <span className="carousel-control-prev-icon" aria-hidden="true" />
            <span className="visually-hidden">Previous</span>
          </button>
          <button
            className="carousel-control-next"
            type="button"
            data-bs-target="#header-carousel"
            data-bs-slide="next"
          >
            <span className="carousel-control-next-icon" aria-hidden="true" />
            <span className="visually-hidden">Next</span>
          </button>
        </div>
      </div>
      <div className="container-fluid banner mb-5">
        <div className="container">
          <div className="row gx-0">
            <div className="col-md-6">
              <div
                className="bg-primary bg-vegetable d-flex flex-column justify-content-center p-5"
                style={{ height: 300 }}
              >
                <h3 className="text-white mb-3">Fresh Milk Products</h3>
                <p className="text-white">
                  Dolor magna ipsum elitr sea erat elitr amet ipsum stet justo
                  dolor, amet lorem diam no duo sed dolore amet diam
                </p>
                {/* <a className="text-white fw-bold" href="/">
            Read More
            <i className="bi bi-arrow-right ms-2" />
          </a> */}
              </div>
            </div>
            <div className="col-md-6">
              <div
                className="bg-secondary bg-fruit d-flex flex-column justify-content-center p-5"
                style={{ height: 300 }}
              >
                <h3 className="text-white mb-3">Organic Vegetable</h3>
                <p className="text-white">
                  Dolor magna ipsum elitr sea erat elitr amet ipsum stet justo
                  dolor, amet lorem diam no duo sed dolore amet diam
                </p>
                {/* <a className="text-white fw-bold" href="/">
            Read More
            <i className="bi bi-arrow-right ms-2" />
          </a> */}
              </div>
            </div>
          </div>
        </div>
      </div>
      {/* <div className="container-fluid bg-primary facts py-5 mb-5">
  <div className="container py-5">
    <div className="row gx-5 gy-4">
      <div className="col-lg-3 col-md-6">
        <div className="d-flex">
          <div
            className="bg-secondary rounded-circle d-flex align-items-center justify-content-center mb-3"
            style={{ width: 60, height: 60 }}
          >
            <i className="fa fa-star fs-4 text-white" />
          </div>
          <div className="ps-4">
            <h5 className="text-white">Our Experience</h5>
            <h1 className="display-5 text-white mb-0" data-toggle="counter-up">
              12345
            </h1>
          </div>
        </div>
      </div>
      <div className="col-lg-3 col-md-6">
        <div className="d-flex">
          <div
            className="bg-secondary rounded-circle d-flex align-items-center justify-content-center mb-3"
            style={{ width: 60, height: 60 }}
          >
            <i className="fa fa-users fs-4 text-white" />
          </div>
          <div className="ps-4">
            <h5 className="text-white">Farm Specialist</h5>
            <h1 className="display-5 text-white mb-0" data-toggle="counter-up">
              12345
            </h1>
          </div>
        </div>
      </div>
      <div className="col-lg-3 col-md-6">
        <div className="d-flex">
          <div
            className="bg-secondary rounded-circle d-flex align-items-center justify-content-center mb-3"
            style={{ width: 60, height: 60 }}
          >
            <i className="fa fa-check fs-4 text-white" />
          </div>
          <div className="ps-4">
            <h5 className="text-white">Complete Project</h5>
            <h1 className="display-5 text-white mb-0" data-toggle="counter-up">
              12345
            </h1>
          </div>
        </div>
      </div>
      <div className="col-lg-3 col-md-6">
        <div className="d-flex">
          <div
            className="bg-secondary rounded-circle d-flex align-items-center justify-content-center mb-3"
            style={{ width: 60, height: 60 }}
          >
            <i className="fa fa-mug-hot fs-4 text-white" />
          </div>
          <div className="ps-4">
            <h5 className="text-white">Happy Clients</h5>
            <h1 className="display-5 text-white mb-0" data-toggle="counter-up">
              12345
            </h1>
          </div>
        </div>
      </div>
    </div>
  </div>
</div> */}
      <div className="container-fluid bg-primary feature py-5 pb-lg-0 my-5">
        <div className="container py-5 pb-lg-0">
          <div
            className="mx-auto text-center mb-3 pb-2"
            style={{ maxWidth: 500 }}
          >
            <h6 className="text-uppercase text-secondary">Features</h6>
            <h1 className="display-5 text-white">Why Choose Us!!!</h1>
          </div>
          <div className="row g-5">
            <div className="col-lg-3">
              <div className="text-white mb-5">
                <div
                  className="bg-secondary rounded-pill d-flex align-items-center justify-content-center mb-3"
                  style={{ width: 60, height: 60 }}
                >
                  <i className="fa fa-seedling fs-4 text-white" />
                </div>
                <h4 className="text-white">100% Organic</h4>
                <p className="mb-0">
                  Labore justo vero ipsum sit clita erat lorem magna clita
                </p>
              </div>
              <div className="text-white">
                <div
                  className="bg-secondary rounded-pill d-flex align-items-center justify-content-center mb-3"
                  style={{ width: 60, height: 60 }}
                >
                  <i className="fa fa-award fs-4 text-white" />
                </div>
                <h4 className="text-white">Award Winning</h4>
                <p className="mb-0">
                  Labore justo vero ipsum sit clita erat lorem magna clita
                </p>
              </div>
            </div>
            <div className="col-lg-6">
              <div className="d-block bg-white h-100 text-center p-5 pb-lg-0">
                <p>
                  At et justo elitr amet sea at. Magna et sit vero at ipsum sit
                  et dolores rebum. Magna sea eos sit dolor, ipsum amet no
                  tempor ipsum eirmod lorem eirmod diam tempor dolor eos diam et
                  et diam dolor ea. Clita est rebum amet dolore sit. Dolor stet
                  dolor duo clita, vero dolor ipsum amet dolore magna lorem erat
                  stet sed vero dolor
                </p>
                <img className="img-fluid" src="img/feature.png" alt="" />
              </div>
            </div>
            <div className="col-lg-3">
              <div className="text-white mb-5">
                <div
                  className="bg-secondary rounded-pill d-flex align-items-center justify-content-center mb-3"
                  style={{ width: 60, height: 60 }}
                >
                  <i className="fa fa-tractor fs-4 text-white" />
                </div>
                <h4 className="text-white">Modern Farming</h4>
                <p className="mb-0">
                  Labore justo vero ipsum sit clita erat lorem magna clita
                </p>
              </div>
              <div className="text-white">
                <div
                  className="bg-secondary rounded-pill d-flex align-items-center justify-content-center mb-3"
                  style={{ width: 60, height: 60 }}
                >
                  <i className="fa fa-phone-alt fs-4 text-white" />
                </div>
                <h4 className="text-white">24/7 Support</h4>
                <p className="mb-0">
                  Labore justo vero ipsum sit clita erat lorem magna clita
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
      {/* <div className="container-fluid py-5">
        <div className="container">
            <div className="mx-auto text-center mb-5" style={{maxWidth: "500px"}}>
                <h6 className="text-primary text-uppercase">The Team</h6>
                <h1 className="display-5">We Are Professional Organic Farmers</h1>
            </div>
            <div className="row g-5">
                <div className="col-lg-4 col-md-6">
                    <div className="row g-0">
                        <div className="col-10">
                            <div className="position-relative">
                                <img className="img-fluid w-100" src="img/team-1.jpg" alt="" />
                                <div className="position-absolute start-0 bottom-0 w-100 py-3 px-4" style={{background: "rgba(52, 173, 84, .85)"}}>
                                    <h4 className="text-white">Farmer Name</h4>
                                    <span className="text-white">Designation</span>
                                </div>
                            </div>
                        </div>
                        <div className="col-2">
                            <div className="h-100 d-flex flex-column align-items-center justify-content-around bg-secondary py-5">
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-twitter text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-facebook-f text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-linkedin-in text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-instagram text-secondary"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="col-lg-4 col-md-6">
                    <div className="row g-0">
                        <div className="col-10">
                            <div className="position-relative">
                                <img className="img-fluid w-100" src="img/team-2.jpg" alt="" />
                                <div className="position-absolute start-0 bottom-0 w-100 py-3 px-4" style={{background: "rgba(52, 173, 84, .85)"}}>
                                    <h4 className="text-white">Farmer Name</h4>
                                    <span className="text-white">Designation</span>
                                </div>
                            </div>
                        </div>
                        <div className="col-2">
                            <div className="h-100 d-flex flex-column align-items-center justify-content-around bg-secondary py-5">
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-twitter text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-facebook-f text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-linkedin-in text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-instagram text-secondary"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="col-lg-4 col-md-6">
                    <div className="row g-0">
                        <div className="col-10">
                            <div className="position-relative">
                                <img className="img-fluid w-100" src="img/team-3.jpg" alt="" />
                                <div className="position-absolute start-0 bottom-0 w-100 py-3 px-4" style={{background: "rgba(52, 173, 84, .85)"}}>
                                    <h4 className="text-white">Farmer Name</h4>
                                    <span className="text-white">Designation</span>
                                </div>
                            </div>
                        </div>
                        <div className="col-2">
                            <div className="h-100 d-flex flex-column align-items-center justify-content-around bg-secondary py-5">
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-twitter text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-facebook-f text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-linkedin-in text-secondary"></i></a>
                                <a className="btn btn-square rounded-circle bg-white" href="/"><i className="fab fa-instagram text-secondary"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> */}
      <div className="container-fluid py-5">
        <div className="container">
          <div
            className="mx-auto text-center mb-5"
            style={{ maxWidth: "500px" }}
          >
            <h6 className="text-primary text-uppercase">Our Product</h6>
            <h1 className="display-5">Product Post</h1>
          </div>
          <div className="row g-5">
            <div className="col-lg-6">
              <div className="blog-item position-relative overflow-hidden">
                <img className="img-fluid" src="img/milk-product-1.png" alt="" />
                <a className="blog-overlay" href="/">
                  <h4 className="text-white">
                    Fresh Milk Products
                  </h4>
                  {/* <span className="text-white fw-bold">Jan 01, 2050</span> */}
                </a>
              </div>
            </div>
            <div className="col-lg-6">
              <div className="blog-item position-relative overflow-hidden">
                <img className="img-fluid" src="img/milk-product-2.png" alt="" />
                <a className="blog-overlay" href="/">
                  <h4 className="text-white">
                    Organic Vegetables
                  </h4>
                  {/* <span className="text-white fw-bold">Jan 01, 2050</span> */}
                </a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
