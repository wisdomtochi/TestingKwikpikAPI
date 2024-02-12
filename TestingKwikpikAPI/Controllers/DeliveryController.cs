using Microsoft.AspNetCore.Mvc;
using TestingKwikpikAPI.Application.ErrorRepo;
using TestingKwikpikAPI.Application.Interfaces;
using TestingKwikpikAPI.Domain.Entities.BatchRequest;
using TestingKwikpikAPI.Domain.Entities.CreateSingleRequest;

namespace TestingKwikpikAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IHomeAPI homeAPI;
        private readonly IAuthenticateAPI authenticateAPI;
        private readonly IWalletAPI walletAPI;
        private readonly IDispatchRequestAPI createSingleRequestAPI;
        private readonly IRequestConfirmationAPI confirmSingleRequestAPI;
        private readonly IBatchRequestAPI batchRequestAPI;
        private readonly IConfirmBatchRequestAPI batchRequestConfirmationAPI;
        private readonly IGetDispatchRequestAPI getDispatchRequest;

        public DeliveryController(IHomeAPI homeAPI,
                                  IAuthenticateAPI authenticateAPI,
                                  IWalletAPI walletAPI,
                                  IDispatchRequestAPI createSingleRequestAPI,
                                  IRequestConfirmationAPI confirmSingleRequestAPI,
                                  IBatchRequestAPI batchRequestAPI,
                                  IConfirmBatchRequestAPI batchRequestConfirmationAPI,
                                  IGetDispatchRequestAPI getDispatchRequest)
        {
            this.homeAPI = homeAPI;
            this.authenticateAPI = authenticateAPI;
            this.walletAPI = walletAPI;
            this.createSingleRequestAPI = createSingleRequestAPI;
            this.confirmSingleRequestAPI = confirmSingleRequestAPI;
            this.batchRequestAPI = batchRequestAPI;
            this.batchRequestConfirmationAPI = batchRequestConfirmationAPI;
            this.getDispatchRequest = getDispatchRequest;
        }

        #region GET WELCOME MESSAGE
        /// <summary>
        /// Gets the welcome message 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("welcome")]
        public async Task<IActionResult> GetWelcomeMessage()
        {
            try
            {
                var message = await homeAPI.GetMessage();
                return Ok(message);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region AUTHENTICATE A USER
        /// <summary>
        /// Checks if the user has been authenticated
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("authenticate")]
        public async Task<IActionResult> GetUserAuthentication()
        {
            try
            {
                var response = await authenticateAPI.GetAuthentication();
                return Ok(response);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region USER WALLET DETAILS
        /// <summary>
        /// Gets the wallet details of a user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("wallet")]
        public async Task<IActionResult> GetUserWallet()
        {
            try
            {
                var response = await walletAPI.GetWalletDetails();
                return Ok(response);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region REQUESTS

        #region CREATE DISPATCH REQUEST
        /// <summary>
        /// Creates a dispatch for a user
        /// </summary>
        /// <param name="createSingleRequest"></param>
        /// <returns></returns>
        [HttpPost]
        //[Route("createsinglerequest")]
        public async Task<IActionResult> CreateSingleRequest([FromBody] CreateSingleRequest createSingleRequest)
        {
            try
            {
                var response = await createSingleRequestAPI.CreateSingleRequest(createSingleRequest);
                return Ok(response);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region CONFIRM DISPATCH REQUEST
        /// <summary>
        /// Confirms the dispatch created
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("confirmsinglerequest/{requestId}")]
        public async Task<IActionResult> ConfirmSingleRequest([FromRoute] string requestId)
        {
            try
            {
                var response = await confirmSingleRequestAPI.ConfirmSingleRequest(requestId);
                return Ok(response);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region GET DISPATCH REQUEST
        /// <summary>
        /// Gets a specific dispatch request with the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("getdispatchrequest/{id}")]
        public async Task<IActionResult> GetDispatchRequest([FromRoute] string id)
        {
            try
            {
                var response = await getDispatchRequest.GetDispatchRequest(id);
                return Ok(response);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region CREATE BATCH REQUEST
        /// <summary>
        /// Creates a batch request
        /// </summary>
        /// <param name = "createBatch" ></ param >
        /// < returns ></ returns>
        [HttpPost]
        [Route("createbatchrequest")]
        public async Task<IActionResult> CreateBatchRequest([FromBody] BatchRequest createBatch)
        {
            try
            {
                var response = await batchRequestAPI.CreateBatchRequest(createBatch);
                return Ok(response);
            }
            catch (Exception e)
            {
                var error = ErrorAPI.GetErrorMessage(e.Message);
                return BadRequest(error);
            }
        }
        #endregion

        #region CONFIRM BATCH REQUEST
        /// <summary>
        /// Confirms the batch request just created
        /// </summary>
        /// <param name="batchRequestConfirmation"></param>
        /// <returns></returns>
        //[HttpPost]
        //[Route("batchconfirmation")]
        //public async Task<IActionResult> ConfirmBatchRequest([FromBody] BatchRequestConfirmation batchRequestConfirmation)
        //{
        //    try
        //    {
        //        var result = await batchRequestConfirmationAPI.ConfirmBatchRequest(batchRequestConfirmation);
        //        return Ok(result);
        //    }
        //    catch (Exception e)
        //    {
        //        var error = ErrorAPI.GetErrorMessage(e.Message);
        //        return BadRequest(error);
        //    }
        //}
        #endregion

        #endregion
    }
}
